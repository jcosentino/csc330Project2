using System;

namespace CSC_330_Project_2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.carrierClickButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.publicationButton = new System.Windows.Forms.RadioButton();
            this.carrierButton = new System.Windows.Forms.RadioButton();
            this.householdsButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClabel = new System.Windows.Forms.Label();
            this.idHlabel = new System.Windows.Forms.Label();
            this.idPlabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Households";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Carriers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.carrierClickButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.publicationButton);
            this.groupBox1.Controls.Add(this.carrierButton);
            this.groupBox1.Controls.Add(this.householdsButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(342, 61);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(220, 32);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Generate Billing";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // carrierClickButton
            // 
            this.carrierClickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierClickButton.Location = new System.Drawing.Point(594, 135);
            this.carrierClickButton.Name = "carrierClickButton";
            this.carrierClickButton.Size = new System.Drawing.Size(35, 44);
            this.carrierClickButton.TabIndex = 26;
            this.carrierClickButton.Text = "C";
            this.carrierClickButton.UseVisualStyleBackColor = true;
            this.carrierClickButton.Visible = false;
            this.carrierClickButton.TextChanged += new System.EventHandler(this.carrierClickButton_TextChanged);
            this.carrierClickButton.Click += new System.EventHandler(this.carrierClickButton_Click);
            this.carrierClickButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.carrierClickButton_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 145);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.Visible = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown_1);
            // 
            // publicationButton
            // 
            this.publicationButton.AutoSize = true;
            this.publicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicationButton.Location = new System.Drawing.Point(192, 147);
            this.publicationButton.Name = "publicationButton";
            this.publicationButton.Size = new System.Drawing.Size(132, 26);
            this.publicationButton.TabIndex = 20;
            this.publicationButton.TabStop = true;
            this.publicationButton.Text = "Publications";
            this.publicationButton.UseVisualStyleBackColor = true;
            this.publicationButton.CheckedChanged += new System.EventHandler(this.publicationButton_CheckedChanged);
            // 
            // carrierButton
            // 
            this.carrierButton.AutoSize = true;
            this.carrierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carrierButton.Location = new System.Drawing.Point(192, 105);
            this.carrierButton.Name = "carrierButton";
            this.carrierButton.Size = new System.Drawing.Size(99, 26);
            this.carrierButton.TabIndex = 19;
            this.carrierButton.TabStop = true;
            this.carrierButton.Text = "Carriers";
            this.carrierButton.UseVisualStyleBackColor = true;
            this.carrierButton.CheckedChanged += new System.EventHandler(this.carrierButton_CheckedChanged);
            // 
            // householdsButton
            // 
            this.householdsButton.AutoSize = true;
            this.householdsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.householdsButton.Location = new System.Drawing.Point(192, 61);
            this.householdsButton.Name = "householdsButton";
            this.householdsButton.Size = new System.Drawing.Size(130, 26);
            this.householdsButton.TabIndex = 18;
            this.householdsButton.TabStop = true;
            this.householdsButton.Text = "Households";
            this.householdsButton.UseVisualStyleBackColor = true;
            this.householdsButton.CheckedChanged += new System.EventHandler(this.householdsButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Publications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search / Add / Delete / Modify";
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(349, 210);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(179, 64);
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Apply";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            this.connectionButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.connectionButton_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 280);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(837, 418);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // idClabel
            // 
            this.idClabel.AutoSize = true;
            this.idClabel.Location = new System.Drawing.Point(595, 207);
            this.idClabel.Name = "idClabel";
            this.idClabel.Size = new System.Drawing.Size(65, 20);
            this.idClabel.TabIndex = 27;
            this.idClabel.Text = "idcarrier";
            this.idClabel.Visible = false;
            // 
            // idHlabel
            // 
            this.idHlabel.AutoSize = true;
            this.idHlabel.Location = new System.Drawing.Point(595, 227);
            this.idHlabel.Name = "idHlabel";
            this.idHlabel.Size = new System.Drawing.Size(103, 20);
            this.idHlabel.TabIndex = 28;
            this.idHlabel.Text = "idhouseholds";
            this.idHlabel.Visible = false;
            // 
            // idPlabel
            // 
            this.idPlabel.AutoSize = true;
            this.idPlabel.Location = new System.Drawing.Point(595, 247);
            this.idPlabel.Name = "idPlabel";
            this.idPlabel.Size = new System.Drawing.Size(105, 20);
            this.idPlabel.TabIndex = 29;
            this.idPlabel.Text = "idpublications";
            this.idPlabel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(106, 210);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 57);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(534, 203);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(188, 50);
            this.instructionLabel.TabIndex = 31;
            this.instructionLabel.Text = "^ USE this box to \r\nedit the carrier IDs";
            this.instructionLabel.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 710);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.idPlabel);
            this.Controls.Add(this.idHlabel);
            this.Controls.Add(this.idClabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectionButton);
            this.Name = "Form3";
            this.Text = "Newspaper Delivery Service";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.RadioButton publicationButton;
        private System.Windows.Forms.RadioButton carrierButton;
        private System.Windows.Forms.RadioButton householdsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button carrierClickButton;
        private System.Windows.Forms.Label idClabel;
        private System.Windows.Forms.Label idHlabel;
        private System.Windows.Forms.Label idPlabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

