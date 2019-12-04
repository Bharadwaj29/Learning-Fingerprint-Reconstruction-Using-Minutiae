using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using PatternRecognition.FingerprintRecognition.Core;
using PatternRecognition.FingerprintRecognition.ResourceProviders;

namespace Finger_Print_Recognition
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();

            var providerByFeatType = new Dictionary<Type, List<Type>>();
            var mtiaListExtractors = new List<Type>();
            var orImgExtractors = new List<Type>();
            var skImgExtractors = new List<Type>();
            var experiments = new List<Type>();

            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);
            foreach (string fileName in Directory.GetFiles(dir))
                try
                {
                    Assembly currAssembly = Assembly.LoadFile(fileName);
                    foreach (Type type in currAssembly.GetExportedTypes())
                        if (type.IsClass && !type.IsAbstract)
                        {
                            var currInterface = type.GetInterface("IFeatureExtractor`1");
                            if (currInterface != null)
                            {
                                var featType = currInterface.GetGenericArguments()[0];
                                if (featType == typeof(List<Minutia>))
                                {
                                    mtiaListExtractors.Add(type);
                                    continue;
                                }

                                if (featType == typeof(OrientationImage))
                                {
                                    orImgExtractors.Add(type);
                                    continue;
                                }

                                if (featType == typeof(SkeletonImage))
                                {
                                    skImgExtractors.Add(type);
                                    continue;
                                }
                            }

                            currInterface = type.GetInterface("IMatchingExperiment");
                            if (currInterface != null)
                            {
                                experiments.Add(type);
                                continue;
                            }

                            currInterface = type.GetInterface("IResourceProvider`1");
                            if (currInterface != null)
                            {
                                var featType = currInterface.GetGenericArguments()[0];
                                if (!providerByFeatType.ContainsKey(featType))
                                    providerByFeatType.Add(featType, new List<Type>());
                                providerByFeatType[featType].Add(type);
                                continue;
                            }

                            currInterface = type.GetInterface("IMatcher`1");
                            if (currInterface != null && !providersByMatcher.ContainsKey(type))
                                providersByMatcher.Add(type, new List<Type>());
                        }
                }
                catch
                {
                }
            foreach (var pair in providersByMatcher)
            {
                var featType = pair.Key.GetInterface("IMatcher`1").GetGenericArguments()[0];
                foreach (var provider in providerByFeatType[featType])
                    pair.Value.Add(provider);
            }
            // Populating cbxMinutiaExtractor
            cbxExperiment.DataSource = experiments;
            cbxExperiment.DisplayMember = "Name";
            cbxExperiment.ValueMember = "Name";

            // Populating cbxMinutiaExtractor
            cbxMinutiaExtractor.DataSource = mtiaListExtractors;
            cbxMinutiaExtractor.DisplayMember = "Name";
            cbxMinutiaExtractor.ValueMember = "Name";

            // Populating cbxMinutiaExtractor
            cbxOrientationImageExtractor.DataSource = orImgExtractors;
            cbxOrientationImageExtractor.DisplayMember = "Name";
            cbxOrientationImageExtractor.ValueMember = "Name";

            // Populating cbxMinutiaExtractor
            cbxSkeletonImageExtractor.DataSource = skImgExtractors;
            cbxSkeletonImageExtractor.DisplayMember = "Name";
            cbxSkeletonImageExtractor.ValueMember = "Name";

            // Populating cbxMatcher
            cbxMatcher.DataSource = new List<Type>(providersByMatcher.Keys);
            cbxMatcher.DisplayMember = "Name";
            cbxMatcher.ValueMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxResources.Text == "")
            {
                MessageBox.Show("Unable to perform visual matching: Unspecified resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(tbxResources.Text))
            {
                MessageBox.Show("Unable to perform visual matching: Invalid resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Type resourceType = resourceProvider.GetType();
            foreach (PropertyInfo propertyInfo in resourceType.GetProperties())
            {
                var currInterface = propertyInfo.PropertyType.GetInterface("IResourceProvider`1");
                if (currInterface != null)
                {
                    var featType = currInterface.GetGenericArguments()[0];
                    if (featType == typeof(OrientationImage))
                    {
                        resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { orImgProvider });
                        continue;
                    }
                    if (featType == typeof(List<Minutia>))
                    {
                        resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { mtiaListProvider });
                        continue;
                    }
                    if (featType == typeof(SkeletonImage))
                    {
                        resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { skImgProvider });
                        continue;
                    }
                }

                if (propertyInfo.CanWrite)
                {
                    currInterface = propertyInfo.PropertyType;
                    if (currInterface.Name == "IFeatureExtractor`1")
                    {
                        var featType = currInterface.GetGenericArguments()[0];
                        if (featType == typeof(OrientationImage))
                        {
                            resourceProvider = orImgProvider;
                            continue;
                        }
                        if (featType == typeof(List<Minutia>))
                        {
                            resourceProvider = mtiaListProvider;
                            continue;
                        }
                        if (featType == typeof(SkeletonImage))
                        {
                            resourceProvider = skImgProvider;
                            continue;
                        }
                    }
                }
            }

            (new Finger_Print_Comparison(matcher, resourceProvider, tbxResources.Text)).ShowDialog();
        }

        private void btnFindResources_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxResources.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        #region private fields

        private MinutiaListProvider mtiaListProvider = new MinutiaListProvider();

        private OrientationImageProvider orImgProvider = new OrientationImageProvider();

        private SkeletonImageProvider skImgProvider = new SkeletonImageProvider();

        private readonly Dictionary<Type, List<Type>> providersByMatcher = new Dictionary<Type, List<Type>>();

        private IMatcher matcher;

        private IMatchingExperiment experiment;

        private IResourceProvider resourceProvider;

        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            experiment.Execute();
        }

        private void cbxMatcher_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type matcherType = (Type)selectedValue;
                matcher = Activator.CreateInstance(matcherType) as IMatcher;

                cbxFeatureProvider.DataSource = providersByMatcher[matcherType];
                cbxFeatureProvider.DisplayMember = "Name";
                cbxFeatureProvider.ValueMember = "Name";

                //cbxMatcher_Enter(sender, e);
            }
        }

        private void cbxFeatureProvider_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type providerType = (Type)selectedValue;
                resourceProvider = Activator.CreateInstance(providerType) as IResourceProvider;
               // cbxFeatureProvider_Enter(sender, e);
            }
        }

        private void cbxMinutiaExtractor_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type extractorType = (Type)selectedValue;
                mtiaListProvider.MinutiaListExtractor = Activator.CreateInstance(extractorType) as IFeatureExtractor<List<Minutia>>;
                //cbxMinutiaExtractor_Enter(sender, e);
            }
        }

        private void cbxOrientationImageExtractor_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type extractorType = (Type)selectedValue;
                orImgProvider.OrientationImageExtractor = Activator.CreateInstance(extractorType) as IFeatureExtractor<OrientationImage>;
               // cbxOrientationImageExtractor_Enter(sender, e);
            }
        }

        private void cbxSkeletonImageExtractor_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type extractorType = (Type)selectedValue;
                skImgProvider.SkeletonImageExtractor = Activator.CreateInstance(extractorType) as IFeatureExtractor<SkeletonImage>;
                //cbxSkeletonImageExtractor_Enter(sender, e);
            }
        }

        private void cbxExperiment_SelectedValueChanged(object sender, EventArgs e)
        {
            object selectedValue = ((ComboBox)sender).SelectedItem;
            if (selectedValue != null)
            {
                Type experimentType = (Type)selectedValue;
                experiment = Activator.CreateInstance(experimentType) as IMatchingExperiment;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbxResources.Text == "")
            {
                MessageBox.Show("Unable to perform experiment: Unspecified resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Directory.Exists(tbxResources.Text))
            {
                MessageBox.Show("Unable to perform experiment: Invalid resource path!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Type resourceType = resourceProvider.GetType();
            foreach (PropertyInfo propertyInfo in resourceType.GetProperties())
            {
                var currInterface = propertyInfo.PropertyType.GetInterface("IResourceProvider`1");
                if (currInterface != null)
                {
                    var featType = currInterface.GetGenericArguments()[0];
                    if (featType == typeof(OrientationImage))
                    {
                        resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { orImgProvider });
                        continue;
                    }
                    if (featType == typeof(List<Minutia>))
                    {
                        resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { mtiaListProvider });
                        continue;
                    }
                    if (featType == typeof(SkeletonImage))
                    {
                        resourceType.InvokeMember(propertyInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, resourceProvider, new object[] { skImgProvider });
                        continue;
                    }
                }

                if (propertyInfo.CanWrite)
                {
                    currInterface = propertyInfo.PropertyType;
                    if (currInterface.Name == "IFeatureExtractor`1")
                    {
                        var featType = currInterface.GetGenericArguments()[0];
                        if (featType == typeof(OrientationImage))
                        {
                            resourceProvider = orImgProvider;
                            continue;
                        }
                        if (featType == typeof(List<Minutia>))
                        {
                            resourceProvider = mtiaListProvider;
                            continue;
                        }
                        if (featType == typeof(SkeletonImage))
                        {
                            resourceProvider = skImgProvider;
                            continue;
                        }
                    }
                }
            }           

            experiment.ResourcePath = tbxResources.Text;
            experiment.ResourceProvider = resourceProvider;
            //experiment.StatusEvent += backgroundWorker1_ProgressChanged;
            experiment.StatusEvent += StatusUpdated;
            experiment.Matcher = matcher;

            backgroundWorker1.RunWorkerAsync();
        }
        private void StatusUpdated(object sender, ProgressChangedEventArgs e)
        {
            backgroundWorker1.ReportProgress(e.ProgressPercentage, e.UserState);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = (string)e.UserState;
            lblProgressValue.Text = string.Format("{0}%", e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
        }

        private void cbxExperiment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
