namespace ProductForm
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
            this.lblbarcode = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblorigin = new System.Windows.Forms.Label();
            this.gbmanufactured = new System.Windows.Forms.GroupBox();
            this.rbabroad = new System.Windows.Forms.RadioButton();
            this.rblocal = new System.Windows.Forms.RadioButton();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.cbcategory = new System.Windows.Forms.ComboBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblmarkup = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtmarkup = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.gbmanufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarcode.Location = new System.Drawing.Point(89, 38);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(69, 17);
            this.lblbarcode.TabIndex = 0;
            this.lblbarcode.Text = "Barcode: ";
            this.lblbarcode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(89, 98);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(53, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name: ";
            this.lblname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbldescription
            // 
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(89, 130);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(87, 17);
            this.lbldescription.TabIndex = 2;
            this.lbldescription.Text = "Description: ";
            this.lbldescription.Click += new System.EventHandler(this.lbldescription_Click);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(89, 233);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(73, 17);
            this.lblcategory.TabIndex = 3;
            this.lblcategory.Text = "Category: ";
            this.lblcategory.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblorigin
            // 
            this.lblorigin.AutoSize = true;
            this.lblorigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorigin.Location = new System.Drawing.Point(89, 263);
            this.lblorigin.Name = "lblorigin";
            this.lblorigin.Size = new System.Drawing.Size(50, 17);
            this.lblorigin.TabIndex = 4;
            this.lblorigin.Text = "Origin:";
            this.lblorigin.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // gbmanufactured
            // 
            this.gbmanufactured.Controls.Add(this.rbabroad);
            this.gbmanufactured.Controls.Add(this.rblocal);
            this.gbmanufactured.Location = new System.Drawing.Point(200, 263);
            this.gbmanufactured.Name = "gbmanufactured";
            this.gbmanufactured.Size = new System.Drawing.Size(273, 71);
            this.gbmanufactured.TabIndex = 5;
            this.gbmanufactured.TabStop = false;
            this.gbmanufactured.Text = "Manufactured:";
            // 
            // rbabroad
            // 
            this.rbabroad.AutoSize = true;
            this.rbabroad.Location = new System.Drawing.Point(156, 30);
            this.rbabroad.Name = "rbabroad";
            this.rbabroad.Size = new System.Drawing.Size(59, 17);
            this.rbabroad.TabIndex = 1;
            this.rbabroad.TabStop = true;
            this.rbabroad.Text = "Abroad";
            this.rbabroad.UseVisualStyleBackColor = true;
            this.rbabroad.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rblocal
            // 
            this.rblocal.AutoSize = true;
            this.rblocal.Location = new System.Drawing.Point(36, 30);
            this.rblocal.Name = "rblocal";
            this.rblocal.Size = new System.Drawing.Size(51, 17);
            this.rblocal.TabIndex = 0;
            this.rblocal.TabStop = true;
            this.rblocal.Text = "Local";
            this.rblocal.UseVisualStyleBackColor = true;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(200, 38);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(273, 23);
            this.txtbarcode.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(200, 95);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(273, 20);
            this.txtname.TabIndex = 7;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(200, 129);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(273, 89);
            this.txtdescription.TabIndex = 8;
            this.txtdescription.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cbcategory
            // 
            this.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategory.FormattingEnabled = true;
            this.cbcategory.Location = new System.Drawing.Point(200, 233);
            this.cbcategory.Name = "cbcategory";
            this.cbcategory.Size = new System.Drawing.Size(273, 21);
            this.cbcategory.TabIndex = 9;
            this.cbcategory.SelectedIndexChanged += new System.EventHandler(this.cbcategory_SelectedIndexChanged);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(89, 347);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(52, 17);
            this.lblstatus.TabIndex = 10;
            this.lblstatus.Text = "Status:";
            this.lblstatus.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Location = new System.Drawing.Point(200, 349);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(56, 17);
            this.chkactive.TabIndex = 11;
            this.chkactive.Text = "Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(89, 392);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(40, 17);
            this.lblcost.TabIndex = 12;
            this.lblcost.Text = "Cost:";
            this.lblcost.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(197, 392);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(44, 17);
            this.lblprice.TabIndex = 13;
            this.lblprice.Text = "Price:";
            this.lblprice.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblmarkup
            // 
            this.lblmarkup.AutoSize = true;
            this.lblmarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarkup.Location = new System.Drawing.Point(353, 392);
            this.lblmarkup.Name = "lblmarkup";
            this.lblmarkup.Size = new System.Drawing.Size(81, 17);
            this.lblmarkup.TabIndex = 14;
            this.lblmarkup.Text = "Markup(%):";
            this.lblmarkup.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(92, 412);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(107, 20);
            this.txtcost.TabIndex = 15;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(200, 412);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(107, 20);
            this.txtprice.TabIndex = 16;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtmarkup
            // 
            this.txtmarkup.Location = new System.Drawing.Point(356, 412);
            this.txtmarkup.Name = "txtmarkup";
            this.txtmarkup.ReadOnly = true;
            this.txtmarkup.Size = new System.Drawing.Size(107, 20);
            this.txtmarkup.TabIndex = 17;
            this.txtmarkup.TextChanged += new System.EventHandler(this.txtmarkup_TextChanged);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(92, 477);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(107, 57);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(200, 477);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(107, 57);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(356, 477);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(107, 57);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 546);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtmarkup);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.lblmarkup);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.chkactive);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.cbcategory);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.gbmanufactured);
            this.Controls.Add(this.lblorigin);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbarcode);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.group_Load);
            this.gbmanufactured.ResumeLayout(false);
            this.gbmanufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblorigin;
        private System.Windows.Forms.GroupBox gbmanufactured;
        private System.Windows.Forms.RadioButton rbabroad;
        private System.Windows.Forms.RadioButton rblocal;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.ComboBox cbcategory;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblmarkup;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtmarkup;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}

