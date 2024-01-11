namespace TicketBook
{
    partial class UserForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("电影列表");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("订单管理");
            this.treeView_admin_menu = new System.Windows.Forms.TreeView();
            this.button_change_user = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.form_container = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView_admin_menu
            // 
            this.treeView_admin_menu.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView_admin_menu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView_admin_menu.Location = new System.Drawing.Point(-2, -1);
            this.treeView_admin_menu.Name = "treeView_admin_menu";
            treeNode1.Name = "FilmView";
            treeNode1.Text = "电影列表";
            treeNode2.Name = "OrderManager";
            treeNode2.Text = "订单管理";
            this.treeView_admin_menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView_admin_menu.Size = new System.Drawing.Size(199, 717);
            this.treeView_admin_menu.TabIndex = 0;
            this.treeView_admin_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_admin_menu_AfterSelect);
            // 
            // button_change_user
            // 
            this.button_change_user.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_change_user.Location = new System.Drawing.Point(7, 561);
            this.button_change_user.Name = "button_change_user";
            this.button_change_user.Size = new System.Drawing.Size(164, 57);
            this.button_change_user.TabIndex = 1;
            this.button_change_user.Text = "切换用户";
            this.button_change_user.UseVisualStyleBackColor = true;
            this.button_change_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.Location = new System.Drawing.Point(7, 634);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(164, 57);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // form_container
            // 
            this.form_container.Location = new System.Drawing.Point(203, 12);
            this.form_container.Name = "form_container";
            this.form_container.Size = new System.Drawing.Size(795, 680);
            this.form_container.TabIndex = 3;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.form_container);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_change_user);
            this.Controls.Add(this.treeView_admin_menu);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_admin_menu;
        private System.Windows.Forms.Button button_change_user;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel form_container;
    }
}