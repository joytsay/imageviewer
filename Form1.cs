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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private string [] folderFile = null;
		private int selected = 0;
		private int begin = 0;
		private int end = 0;
        private int count = 0;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label4;
        private GroupBox groupBox1;
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 589);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(790, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(260, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<< Previous";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(404, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open Folder";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(540, 13);
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
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.Location = new System.Drawing.Point(260, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(408, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "<< START Slide Show >>";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(685, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "1000";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(685, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "1";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "0 times";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(853, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "2";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "millisec";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(959, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "size";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 608);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
				string [] part1=null, part2=null, part3 = null, part4 = null;

				part1 = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.jpg");
				part2 = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.jpeg");
				part3 = Directory.GetFiles(folderBrowserDialog1.SelectedPath,"*.bmp");
                part4 = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.png");

                folderFile = new string[part1.Length + part2.Length + part3.Length + part4.Length];

				Array.Copy(part1,0,folderFile,0,part1.Length);
				Array.Copy(part2,0,folderFile,part1.Length,part2.Length);
				Array.Copy(part3,0,folderFile,part1.Length + part2.Length,part3.Length);
                Array.Copy(part4, 0, folderFile, part1.Length + part2.Length+ part3.Length, part4.Length);

                selected = 0;
				begin = 0;
				end = folderFile.Length;

				showImage(folderFile[selected],-1);

				button1.Enabled = true;
				button3.Enabled = true;
				button4.Enabled = true;
			}
		}

		private void showImage(string path, int selected)
		{
            if (selected < 0)
            {
                Image imgtemp = Image.FromFile(path);
                pictureBox1.Width = imgtemp.Width*Convert.ToInt32(textBox3.Text);
                pictureBox1.Height = imgtemp.Height*Convert.ToInt32(textBox3.Text);
                pictureBox1.Image = imgtemp;
            }
            else if (selected %2 == 0)
            {
                Image imgtemp = Image.FromFile(path);
                pictureBox1.Width = imgtemp.Width*Convert.ToInt32(textBox3.Text);
                pictureBox1.Height = imgtemp.Height*Convert.ToInt32(textBox3.Text);
                pictureBox1.Image = imgtemp;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                Image imgtemp = Image.FromFile(path);
                pictureBox2.Width = imgtemp.Width*Convert.ToInt32(textBox3.Text);
                pictureBox2.Height = imgtemp.Height*Convert.ToInt32(textBox3.Text);
                pictureBox2.Image = imgtemp;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
		}

		private void prevImage()
		{
			if(selected == 0)
			{
				selected = folderFile.Length - 1;
				showImage(folderFile[selected], selected);		
			}
			else
			{
				selected = selected - 1;                				
				showImage(folderFile[selected], selected);
			}
		}

		private void nextImage()
		{
			if(selected == folderFile.Length - 1)
			{
				selected = 0;				
				showImage(folderFile[selected], selected);
			}
			else
			{
				selected = selected + 1;                				
				showImage(folderFile[selected], selected);
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
            if(count == (Convert.ToInt32(textBox2.Text))*(end))
            {
                selected = 0;
                count = 0;
                timer1.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                button4.Text = "<< START Slide Show >>";
            }
            else
            {
                count++;
                nextImage();
            }
            label1.Text = Convert.ToString(Convert.ToDecimal(count / end)) + " times";
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
                selected = -1;
                timer1.Interval = Convert.ToInt32(textBox1.Text);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
