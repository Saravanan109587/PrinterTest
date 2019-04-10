namespace Printer
{
    partial class PrinterTest
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
            this.availablePrinters = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.data_Printer = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Printer)).BeginInit();
            this.SuspendLayout();
            // 
            // availablePrinters
            // 
            this.availablePrinters.FormattingEnabled = true;
            this.availablePrinters.Location = new System.Drawing.Point(450, 34);
            this.availablePrinters.Name = "availablePrinters";
            this.availablePrinters.Size = new System.Drawing.Size(314, 21);
            this.availablePrinters.TabIndex = 0;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(397, 77);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(103, 59);
            this.btn_print.TabIndex = 1;
            this.btn_print.Text = "Print Test Page";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select  Printer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 59);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // data_Printer
            // 
            this.data_Printer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Printer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Printer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Printer.Location = new System.Drawing.Point(12, 207);
            this.data_Printer.Name = "data_Printer";
            this.data_Printer.Size = new System.Drawing.Size(1316, 299);
            this.data_Printer.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(691, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "Check Online";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.BackColor = System.Drawing.Color.Red;
            this.btn_clr.Location = new System.Drawing.Point(828, 23);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(92, 41);
            this.btn_clr.TabIndex = 6;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = false;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // PrinterTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 518);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.data_Printer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.availablePrinters);
            this.Name = "PrinterTest";
            this.Text = "Pinter Test";
            ((System.ComponentModel.ISupportInitialize)(this.data_Printer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox availablePrinters;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView data_Printer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_clr;
    }
}

