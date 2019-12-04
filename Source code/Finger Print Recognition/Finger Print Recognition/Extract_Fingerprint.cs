using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using PatternRecognition.FingerprintRecognition.Core;

namespace Finger_Print_Recognition
{
    public partial class Extract_Fingerprint : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        readonly Dictionary<Type, Type> featTypeByDisplay = new Dictionary<Type, Type>();
        readonly Dictionary<Type, List<Type>> extractorsByFeatType = new Dictionary<Type, List<Type>>();
        private IFeatureDisplay currFeatDisplay;
        private IFeatureExtractor currExtractor;
        private Bitmap img = null;

        List<Type> itemsource;
        List<Type> selitem;
        public Extract_Fingerprint()
        {
            InitializeComponent();
            Assembly thisAss = Assembly.GetExecutingAssembly();
            string dir = Path.GetDirectoryName(thisAss.Location);
            foreach (string fileName in Directory.GetFiles(dir))
            {
                string fileExtension = Path.GetExtension(fileName);
                if (fileExtension == ".dll")
                {
                    try
                    {
                        Assembly currAssembly = Assembly.LoadFile(fileName);
                        foreach (Type type in currAssembly.GetExportedTypes())
                        {
                            var currInterface = type.GetInterface("IFeatureDisplay`1");
                            if (type.IsClass && !type.IsAbstract && currInterface != null)
                            {
                                var featType = currInterface.GetGenericArguments()[0];
                                featTypeByDisplay.Add(type, featType);
                            }

                            currInterface = type.GetInterface("IFeatureExtractor`1");
                            if (type.IsClass && !type.IsAbstract && currInterface != null)
                            {
                                var featType = currInterface.GetGenericArguments()[0];
                                if (!extractorsByFeatType.ContainsKey(featType))
                                    extractorsByFeatType.Add(featType, new List<Type>());
                                extractorsByFeatType[featType].Add(type);
                            }
                        }
                    }
                    catch (Exception e)
                    {  }
                }
            }
            var toDelete = new List<Type>();
            foreach (var pair in featTypeByDisplay)
                if (!extractorsByFeatType.ContainsKey(pair.Value))
                    toDelete.Add(pair.Key);
            foreach (var type in toDelete)
                featTypeByDisplay.Remove(type);
        }

        private void Extract_Fingerprint_Load(object sender, EventArgs e)
        {
            itemsource = new List<Type>(featTypeByDisplay.Keys);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img = ImageLoader.LoadImage(openFileDialog1.FileName);
                pictureBox1.Image = img;
                button2.Visible = true;

                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(pictureBox6.Width);                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            object selectedValue = itemsource[1];
            if (selectedValue != null)
            {
                Type selectedType = (Type)selectedValue;
                currFeatDisplay = Activator.CreateInstance(selectedType) as IFeatureDisplay;               
                Type currFeatType = featTypeByDisplay[selectedType];
                selitem = extractorsByFeatType[currFeatType];                
            }
            object selvalue = selitem[0];
            if (selvalue != null)
            {
                Type selType = (Type)selvalue;
                currExtractor = Activator.CreateInstance(selType) as IFeatureExtractor;
            }
            if (img == null)
            {
                MessageBox.Show("You must select an image!", "Displaying error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox2.Image = img.Clone() as Bitmap;
            Graphics g = Graphics.FromImage(pictureBox2.Image);            
            {
                var features = currExtractor.ExtractFeatures(img);
                currFeatDisplay.Show(features, g);
                button3.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            object selectedValue = itemsource[3];
            if (selectedValue != null)
            {
                Type selectedType = (Type)selectedValue;
                currFeatDisplay = Activator.CreateInstance(selectedType) as IFeatureDisplay;
                Type currFeatType = featTypeByDisplay[selectedType];
                selitem = extractorsByFeatType[currFeatType];
            }
            object selvalue = selitem[0];
            if (selvalue != null)
            {
                Type selType = (Type)selvalue;
                currExtractor = Activator.CreateInstance(selType) as IFeatureExtractor;
            }
            if (img == null)
            {
                MessageBox.Show("You must select an image!", "Displaying error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox3.Image = img.Clone() as Bitmap;
            Graphics g = Graphics.FromImage(pictureBox3.Image);
            {
                var features = currExtractor.ExtractFeatures(img);
                currFeatDisplay.Show(features, g);
                button4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            object selectedValue = itemsource[2];
            if (selectedValue != null)
            {
                Type selectedType = (Type)selectedValue;
                currFeatDisplay = Activator.CreateInstance(selectedType) as IFeatureDisplay;
                Type currFeatType = featTypeByDisplay[selectedType];
                selitem = extractorsByFeatType[currFeatType];
            }
            object selvalue = selitem[0];
            if (selvalue != null)
            {
                Type selType = (Type)selvalue;
                currExtractor = Activator.CreateInstance(selType) as IFeatureExtractor;
            }
            if (img == null)
            {
                MessageBox.Show("You must select an image!", "Displaying error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox4.Image = img.Clone() as Bitmap;
            Graphics g = Graphics.FromImage(pictureBox4.Image);
            {
                var features = currExtractor.ExtractFeatures(img);
                currFeatDisplay.Show(features, g);
                button5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            object selectedValue = itemsource[0];
            if (selectedValue != null)
            {
                Type selectedType = (Type)selectedValue;
                currFeatDisplay = Activator.CreateInstance(selectedType) as IFeatureDisplay;
                Type currFeatType = featTypeByDisplay[selectedType];
                selitem = extractorsByFeatType[currFeatType];
            }
            object selvalue = selitem[0];
            if (selvalue != null)
            {
                Type selType = (Type)selvalue;
                currExtractor = Activator.CreateInstance(selType) as IFeatureExtractor;
            }
            if (img == null)
            {
                MessageBox.Show("You must select an image!", "Displaying error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pictureBox5.Image = img.Clone() as Bitmap;
            Graphics g = Graphics.FromImage(pictureBox5.Image);
            {
                var features = currExtractor.ExtractFeatures(img);
                currFeatDisplay.Show(features, g);
                button6.Visible = true;
                //groupBox6.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            Bitmap bitmapResult = null;

            bitmapResult = previewBitmap.Sobel3x3Filter();

            pictureBox6.Image = bitmapResult;
            
        }
        private void ApplyFilter()
        {          
            
        }
    }
}
