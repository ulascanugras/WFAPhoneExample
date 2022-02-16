
namespace WFAPhoneAbstractionExample
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEricson = new System.Windows.Forms.Button();
            this.btnIphone = new System.Windows.Forms.Button();
            this.btnNokia = new System.Windows.Forms.Button();
            this.btnSamsung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abstract soyut, Concrete somut.";
            // 
            // btnEricson
            // 
            this.btnEricson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEricson.Location = new System.Drawing.Point(38, 12);
            this.btnEricson.Name = "btnEricson";
            this.btnEricson.Size = new System.Drawing.Size(174, 87);
            this.btnEricson.TabIndex = 1;
            this.btnEricson.Text = "Ericson";
            this.btnEricson.UseVisualStyleBackColor = true;
            this.btnEricson.Click += new System.EventHandler(this.btnEricson_Click);
            // 
            // btnIphone
            // 
            this.btnIphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIphone.Location = new System.Drawing.Point(38, 105);
            this.btnIphone.Name = "btnIphone";
            this.btnIphone.Size = new System.Drawing.Size(174, 87);
            this.btnIphone.TabIndex = 1;
            this.btnIphone.Text = "Iphone";
            this.btnIphone.UseVisualStyleBackColor = true;
            this.btnIphone.Click += new System.EventHandler(this.btnIphone_Click);
            // 
            // btnNokia
            // 
            this.btnNokia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNokia.Location = new System.Drawing.Point(38, 198);
            this.btnNokia.Name = "btnNokia";
            this.btnNokia.Size = new System.Drawing.Size(174, 87);
            this.btnNokia.TabIndex = 1;
            this.btnNokia.Text = "Nokia";
            this.btnNokia.UseVisualStyleBackColor = true;
            this.btnNokia.Click += new System.EventHandler(this.btnNokia_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSamsung.Location = new System.Drawing.Point(38, 291);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(174, 87);
            this.btnSamsung.TabIndex = 1;
            this.btnSamsung.Text = "Samsung";
            this.btnSamsung.UseVisualStyleBackColor = true;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 450);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.btnNokia);
            this.Controls.Add(this.btnIphone);
            this.Controls.Add(this.btnEricson);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEricson;
        private System.Windows.Forms.Button btnIphone;
        private System.Windows.Forms.Button btnNokia;
        private System.Windows.Forms.Button btnSamsung;
    }
}

