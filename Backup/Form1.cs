using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace imageviewer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private string [] folderFile = null;
		private int selected = 0;
		private int begin = 0;
		private int end = 0;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button4;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(424, 248);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "<< Previous";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(152, 256);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Open Folder";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(288, 256);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Next >>";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(8, 288);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(408, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "<< START Slide Show >>";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 317);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vision";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string [] part1=null, part2=null, part3=null;

				part1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.jpg");
				part2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.jpeg");
				part3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.bmp");

				folderFile = new string[part1.Length + part2.Length + part3.Length];

				Array.Copy(part1,0,folderFile,0,part1.Length);
				Array.Copy(part2,0,folderFile,part1.Length,part2.Length);
				Array.Copy(part3,0,folderFile,part1.Length + part2.Length,part3.Length);

				selected = 0;
				begin = 0;
				end = folderFile.Length;

				showImage(folderFile[selected]);

				button1.Enabled = true;
				button3.Enabled = true;
				button4.Enabled = true;
			}
		}

		private void showImage(string path)
		{
			Image imgtemp = Image.FromFile(path);
			pictureBox1.Width = imgtemp.Width / 2;
			pictureBox1.Height = imgtemp.Height / 2;
			pictureBox1.Image = imgtemp;
		}

		private void prevImage()
		{
			if(selected == 0)
			{
				selected = folderFile.Length - 1;
				showImage(folderFile[selected]);		
			}
			else
			{
				selected = selected - 1;                				
				showImage(folderFile[selected]);
			}
		}

		private void nextImage()
		{
			if(selected == folderFile.Length - 1)
			{
				selected = 0;				
				showImage(folderFile[selected]);
			}
			else
			{
				selected = selected + 1;                				
				showImage(folderFile[selected]);
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			prevImage();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			nextImage();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			nextImage();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(timer1.Enabled == true)
			{
				timer1.Enabled = false;
				button4.Text = "<< START Slide Show >>";
			}
			else
			{
				timer1.Enabled = true;
				button4.Text = "<< STOP Slide Show >>";
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			button1.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
		}
	}
}
