
namespace DBConnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.Menu.AllowDrop = true;
            this.Menu.AutoClose = false;
            this.Menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Menu.DropShadowEnabled = false;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConnect,
            this.MenuDisconnect});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu.ShowImageMargin = false;
            this.Menu.Size = new System.Drawing.Size(187, 52);
            this.Menu.TabStop = true;
            this.Menu.Text = "Menu";
            // 
            // MenuItemConnect
            // 
            this.MenuItemConnect.Name = "MenuItemConnect";
            this.MenuItemConnect.Size = new System.Drawing.Size(186, 24);
            this.MenuItemConnect.Text = "Connect to DB";
            this.MenuItemConnect.Click += new System.EventHandler(this.MenuItemConnect_Click);
            // 
            // MenuDisconnect
            // 
            this.MenuDisconnect.Name = "MenuDisconnect";
            this.MenuDisconnect.Size = new System.Drawing.Size(186, 24);
            this.MenuDisconnect.Text = "Disconnect from DB";
            this.MenuDisconnect.Click += new System.EventHandler(this.MenuDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.Menu;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "lab1";
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuDisconnect;
    }
}

