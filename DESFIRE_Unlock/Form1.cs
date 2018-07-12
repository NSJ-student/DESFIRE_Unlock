/* http://marufloor.tistory.com/79 */
/* http://blueasa.tistory.com/627 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DESFIRE_Unlock
{
	public partial class Form1 : Form
	{
		[DllImport("DESFIRE_UNLOCK.dll")]
		public static extern void triple_des_cbc_encrypt(byte[] input_data, byte[] result, int size, byte[] init_vector);

		[DllImport("DESFIRE_UNLOCK.dll")]
		public static extern void triple_des_cbc_decrypt(byte[] input_data, byte[] result, int size, byte[] init_vector);

		public Form1()
		{
			InitializeComponent();
		}

		private void btnConvert_Click(object sender, EventArgs e)
		{
			byte[] iv = GetByteArrayFromString(tbInitVector.Text);
			byte[] input = GetByteArrayFromString(tbInput.Text);
			byte[] output = new byte[8];

			triple_des_cbc_encrypt(input, output, 8, iv);
			
			tbOutput.Text = String.Format("{0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2}",
					output[0], output[1], output[2], output[3],
					output[4], output[5], output[6], output[7]);
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			byte[] iv = GetByteArrayFromString(tbInitVector.Text);
			byte[] input = GetByteArrayFromString(tbInput.Text);
			byte[] output = new byte[8];

			triple_des_cbc_decrypt(input, output, 8, iv);

			tbOutput.Text = String.Format("{0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2}",
					output[0], output[1], output[2], output[3],
					output[4], output[5], output[6], output[7]);
		}

		private byte[] GetByteArrayFromString(string origin)
		{
			byte[] result = new byte[8];
			string[] str_iv = origin.Split(' ');
			for (int cnt = 0; cnt < 8; cnt++)
			{
				result[cnt] = byte.Parse(str_iv[cnt], System.Globalization.NumberStyles.HexNumber);
			}

			return result;
		}

	}
}
