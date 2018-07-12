namespace DESFIRE_Unlock
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbInput = new System.Windows.Forms.Label();
			this.tbInput = new System.Windows.Forms.TextBox();
			this.tbOutput = new System.Windows.Forms.TextBox();
			this.lbOutput = new System.Windows.Forms.Label();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.tbInitVector = new System.Windows.Forms.TextBox();
			this.lbInitVector = new System.Windows.Forms.Label();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbInput
			// 
			this.lbInput.AutoSize = true;
			this.lbInput.Location = new System.Drawing.Point(32, 30);
			this.lbInput.Name = "lbInput";
			this.lbInput.Size = new System.Drawing.Size(48, 15);
			this.lbInput.TabIndex = 0;
			this.lbInput.Text = "Input :";
			// 
			// tbInput
			// 
			this.tbInput.Location = new System.Drawing.Point(116, 27);
			this.tbInput.Name = "tbInput";
			this.tbInput.Size = new System.Drawing.Size(248, 25);
			this.tbInput.TabIndex = 1;
			// 
			// tbOutput
			// 
			this.tbOutput.Location = new System.Drawing.Point(116, 89);
			this.tbOutput.Name = "tbOutput";
			this.tbOutput.Size = new System.Drawing.Size(248, 25);
			this.tbOutput.TabIndex = 3;
			// 
			// lbOutput
			// 
			this.lbOutput.AutoSize = true;
			this.lbOutput.Location = new System.Drawing.Point(32, 92);
			this.lbOutput.Name = "lbOutput";
			this.lbOutput.Size = new System.Drawing.Size(61, 15);
			this.lbOutput.TabIndex = 2;
			this.lbOutput.Text = "Output :";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(381, 27);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(84, 40);
			this.btnEncrypt.TabIndex = 4;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// tbInitVector
			// 
			this.tbInitVector.Location = new System.Drawing.Point(116, 58);
			this.tbInitVector.Name = "tbInitVector";
			this.tbInitVector.Size = new System.Drawing.Size(248, 25);
			this.tbInitVector.TabIndex = 6;
			this.tbInitVector.Text = "00 00 00 00 00 00 00 00";
			// 
			// lbInitVector
			// 
			this.lbInitVector.AutoSize = true;
			this.lbInitVector.Location = new System.Drawing.Point(32, 61);
			this.lbInitVector.Name = "lbInitVector";
			this.lbInitVector.Size = new System.Drawing.Size(81, 15);
			this.lbInitVector.TabIndex = 5;
			this.lbInitVector.Text = "Init Vector :";
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(381, 74);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(84, 40);
			this.btnDecrypt.TabIndex = 7;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 137);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.tbInitVector);
			this.Controls.Add(this.lbInitVector);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.tbOutput);
			this.Controls.Add(this.lbOutput);
			this.Controls.Add(this.tbInput);
			this.Controls.Add(this.lbInput);
			this.Name = "Form1";
			this.Text = "DESFIRE Decryption";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbInput;
		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.TextBox tbOutput;
		private System.Windows.Forms.Label lbOutput;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.TextBox tbInitVector;
		private System.Windows.Forms.Label lbInitVector;
		private System.Windows.Forms.Button btnDecrypt;
	}
}

