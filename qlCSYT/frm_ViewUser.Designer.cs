using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using qlCSYT;

namespace qlCSYT
{
    partial class frm_ViewUser
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
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUser.Location = new System.Drawing.Point(-3, -3);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.RowHeadersWidth = 51;
            this.DataGridViewUser.RowTemplate.Height = 24;
            this.DataGridViewUser.Size = new System.Drawing.Size(342, 276);
            this.DataGridViewUser.TabIndex = 0;
            this.DataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewUser_CellContentClick);
            // 
            // frm_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewUser);
            this.Name = "frm_ViewUser";
            this.Text = "View User";
            this.Load += new System.EventHandler(this.frm_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUser;
    }
}