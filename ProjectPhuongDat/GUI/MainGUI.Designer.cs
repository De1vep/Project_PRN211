namespace ProjectPhuongDat.GUI
{
    partial class MainGUI
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
            components = new System.ComponentModel.Container();
            albumBindingSource = new BindingSource(components);
            lbCart = new Label();
            lbShopping = new Label();
            lblLog = new Label();
            lbAdmin = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            panel1 = new Panel();
            lblSignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lbCart
            // 
            lbCart.AutoSize = true;
            lbCart.Location = new Point(126, 21);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(36, 20);
            lbCart.TabIndex = 1;
            lbCart.Text = "Cart";
            lbCart.Click += lbCart_Click;
            // 
            // lbShopping
            // 
            lbShopping.AutoSize = true;
            lbShopping.Location = new Point(11, 20);
            lbShopping.Name = "lbShopping";
            lbShopping.Size = new Size(73, 20);
            lbShopping.TabIndex = 0;
            lbShopping.Text = "Shopping";
            lbShopping.Click += lbShopping_Click;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(208, 21);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(56, 20);
            lblLog.TabIndex = 2;
            lblLog.Text = "Logout";
            // 
            // lbAdmin
            // 
            lbAdmin.AutoSize = true;
            lbAdmin.Location = new Point(414, 20);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(59, 20);
            lbAdmin.TabIndex = 3;
            lbAdmin.Text = "Albums";
            lbAdmin.Click += lbAdmin_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 770);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1077, 26);
            statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 20);
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(417, 20);
            toolStripStatusLabel3.Text = "Project:HE150271_ĐàoXuânPhương   HE150862_PhạmTiếnĐạt";
            // 
            // panel1
            // 
            panel1.Location = new Point(15, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 712);
            panel1.TabIndex = 5;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Location = new Point(313, 20);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(57, 20);
            lblSignUp.TabIndex = 6;
            lblSignUp.Text = "SignUp";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // MainGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 796);
            Controls.Add(lblSignUp);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(lbAdmin);
            Controls.Add(lblLog);
            Controls.Add(lbShopping);
            Controls.Add(lbCart);
            Name = "MainGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainGUI";
            ((System.ComponentModel.ISupportInitialize)albumBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbCart;
        private Label lbShopping;
        private Label lblLog;
        private Label lbAdmin;
        private BindingSource albumBindingSource;
        private DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn albumUrlDataGridViewTextBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private Label lblSignUp;
    }
}