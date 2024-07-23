namespace Pav.TpFinal.Presentacion.Vistas
{
    partial class PrincipalView
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            agregarAnimalToolStripMenuItem = new ToolStripMenuItem();
            verZooToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { agregarAnimalToolStripMenuItem, verZooToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(69, 20);
            toolStripMenuItem1.Text = "Opciones";
            // 
            // agregarAnimalToolStripMenuItem
            // 
            agregarAnimalToolStripMenuItem.Name = "agregarAnimalToolStripMenuItem";
            agregarAnimalToolStripMenuItem.Size = new Size(180, 22);
            agregarAnimalToolStripMenuItem.Text = "Agregar Animal";
            // 
            // verZooToolStripMenuItem
            // 
            verZooToolStripMenuItem.Name = "verZooToolStripMenuItem";
            verZooToolStripMenuItem.Size = new Size(180, 22);
            verZooToolStripMenuItem.Text = "Ver Zoo";
            // 
            // PrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PrincipalView";
            Text = "PAV2024 - TP Final";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem agregarAnimalToolStripMenuItem;
        private ToolStripMenuItem verZooToolStripMenuItem;
    }
}