# Learning-Fingerprint-Reconstruction-Using-Minutiae
ABSTRACT:
The set of minutia points is considered to be the most distinctive feature for fingerprint representation and is widely used in fingerprint matching. It was believed that the minutiae set does not contain sufficient information to reconstruct the original fingerprint image from which minutiae were extracted. However, recent studies have shown that it is indeed possible to reconstruct fingerprint images from their minutiae representations. Reconstruction techniques demonstrate the need for securing fingerprint templates, improving the template interoperability, and improving fingerprint synthesis. But, there is still a large gap between the matching performance obtained from original fingerprint images and their corresponding reconstructed fingerprint images. In this paper, the prior knowledge about fingerprint ridge structures is encoded in terms of orientation patch and continuous phase patch dictionaries to improve the fingerprint reconstruction. The orientation patch dictionary is used to reconstruct the orientation field from minutiae, while the continuous phase patch dictionary is used to reconstruct the ridge pattern. Experimental results on three public domain databases (FVC2002 DB1_A, FVC2002 DB2_A, and NIST SD4) demonstrate that the proposed reconstruction algorithm outperforms the state-of-the-art reconstruction algorithms in terms of both: 1) spurious minutiae and 2) matching performance with respect to type-I attack (matching the reconstructed fingerprint against the same impression from which minutiae set was extracted) and type-II attack (matching the reconstructed fingerprint against a different impression of the same finger). 
EXISTING SYSTEM:
	Existing reconstruction algorithms essentially consist of two main steps: i) orientation field reconstruction and ii) ridge pattern reconstruction. The orientation field, which determines the ridge flow, can be reconstructed from minutiae and/or singular points. 
	In existing work, the orientation field was reconstructed from the singular points (core and delta) using the zeropole model. However, the orientation field in fingerprints cannot simply be accounted for by singular points only. 
	Cappelli et al. proposed a variant of the zeropole model with additional degrees of freedom to fit the model to the minutiae directions. However, the orientation field reconstructed based on zero-pole model cannot be guaranteed when the singular points are not available. 
	In another existing work, a set of minutiae triplets was proposed to reconstruct orientation field in triangles without using singular points. The algorithm proposed by Feng and Jain predicts an orientation value for each block by using the nearest minutia in each of the eight sectors.
DISADVANTAGES OF EXISTING SYSTEM:
	Although several fingerprint reconstruction algorithms have been proposed, the matching performance of the reconstructed fingerprints compared with the original fingerprint images is still not very satisfactory. That means the reconstructed fingerprint image is not very close to the original fingerprint image that the minutiae were extracted from. 
	An important reason for this loss of matching performance is that no prior knowledge of fingerprint ridge structure was utilized in these reconstruction approaches to reproduce the fingerprint characteristics.
PROPOSED SYSTEM:
	We propose to reconstruct fingerprint patches using continuous phase patch dictionary and minutiae belonging to these patches; these patches are optimally selected to form a fingerprint image. The spurious minutiae, which are detected in the phase of the reconstructed fingerprint image but not included in the input minutiae template, are then removed using the global AF-FM model. The proposed reconstruction algorithm has been evaluated on three different public domain databases.
	The goal of fingerprint reconstruction is to reconstruct a gray-scale fingerprint image based on an input se.
	In this paper, a dictionary-based fingerprint reconstruction method is proposed. Two kinds of dictionaries are learnt off-line as prior knowledge: 1) orientation patch dictionary and 2) continuous phase patch dictionary. For an input fingerprint minutiae set, the orientation patch dictionary is used to reconstruct the orientation field from the minutiae set, while the continuous phase dictionary is used to reconstruct the ridge pattern. In addition, the spurious minutiae introduced in the reconstructed fingerprint are removed using the global AM-FM model.

ADVANTAGES OF PROPOSED SYSTEM:
	Given the prior knowledge of orientation pattern (i.e., orientation patch dictionary), the orientation field reconstructed from the proposed algorithm is better than the method proposed in existing; the singular points obtained from the proposed algorithm are very close to the original ones.
	Experimental results demonstrate that the proposed algorithm performs better than two state of- the-art reconstruction algorithms.
	Use of prior knowledge of orientation pattern, i.e., orientation patch dictionary, which provides better orientation field reconstruction, especially around singular points.
	Instead of generating a continuous phase and then adding spiral phase to the continuous phase globally, this procedure is able to better preserve the ridge structure.
	Use of local ridge frequency around minutiae.
SYSTEM REQUIREMENTS:
HARDWARE REQUIREMENTS:

	System		 	: 	Pentium IV 2.4 GHz.
	Hard Disk           		: 	40 GB.
	Floppy Drive		: 	1.44 Mb.
	Monitor			: 	15 VGA Colour.
	Mouse			: 	Logitech.
	Ram				: 	512 Mb.

SOFTWARE REQUIREMENTS:

	Operating system 	: 	Windows XP/7.
	Coding Language	: 	C#.net
	Tool			:	Visual Studio 2010
	Database		:	SQL SERVER 2008

