//
// SubmitPrjPkgManage.Designer.cs
//
// Author:
//       Surfzoid <surfzoid@gmail.com>
//
// Copyright (c) 2009 Surfzoid
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace MonoOSC.Ctrl.SubmitReq
{
partial class SubmitPrjPkgManage
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.CmbxAction = new System.Windows.Forms.ComboBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.TxtMess = new System.Windows.Forms.TextBox();
        this.TxtLogID = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.BtnDoIt = new System.Windows.Forms.Button();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        //
        // groupBox1
        //
        this.groupBox1.Controls.Add(this.CmbxAction);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.label1);
        this.groupBox1.Controls.Add(this.TxtMess);
        this.groupBox1.Controls.Add(this.TxtLogID);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.BtnDoIt);
        this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.groupBox1.Location = new System.Drawing.Point(0, 0);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(319, 148);
        this.groupBox1.TabIndex = 16;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Manage";
        //
        // CmbxAction
        //
        this.CmbxAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.CmbxAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
        this.CmbxAction.FormattingEnabled = true;
        this.CmbxAction.Items.AddRange(new object[]
        {
            "Accept",
            "Decline",
            "Delete",
            "Revoke"
        });
        this.CmbxAction.Location = new System.Drawing.Point(49, 49);
        this.CmbxAction.MaxDropDownItems = 20;
        this.CmbxAction.Name = "CmbxAction";
        this.CmbxAction.Size = new System.Drawing.Size(144, 21);
        this.CmbxAction.TabIndex = 15;
        this.CmbxAction.Text = "Accept";
        //
        // label2
        //
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(6, 52);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(37, 13);
        this.label2.TabIndex = 14;
        this.label2.Text = "Action";
        //
        // label1
        //
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(144, 16);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(50, 13);
        this.label1.TabIndex = 13;
        this.label1.Text = "Message";
        //
        // TxtMess
        //
        this.TxtMess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                               | System.Windows.Forms.AnchorStyles.Left)
                               | System.Windows.Forms.AnchorStyles.Right)));
        this.TxtMess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.TxtMess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
        this.TxtMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.TxtMess.Location = new System.Drawing.Point(199, 14);
        this.TxtMess.Multiline = true;
        this.TxtMess.Name = "TxtMess";
        this.TxtMess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.TxtMess.Size = new System.Drawing.Size(114, 128);
        this.TxtMess.TabIndex = 12;
        this.TxtMess.WordWrap = false;
        //
        // TxtLogID
        //
        this.TxtLogID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.TxtLogID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
        this.TxtLogID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.TxtLogID.Location = new System.Drawing.Point(30, 14);
        this.TxtLogID.Name = "TxtLogID";
        this.TxtLogID.Size = new System.Drawing.Size(108, 23);
        this.TxtLogID.TabIndex = 9;
        //
        // label3
        //
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(6, 19);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(18, 13);
        this.label3.TabIndex = 8;
        this.label3.Text = "ID";
        //
        // BtnDoIt
        //
        this.BtnDoIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
        this.BtnDoIt.Location = new System.Drawing.Point(9, 93);
        this.BtnDoIt.Name = "BtnDoIt";
        this.BtnDoIt.Size = new System.Drawing.Size(59, 23);
        this.BtnDoIt.TabIndex = 11;
        this.BtnDoIt.Text = "Do it !";
        this.BtnDoIt.UseVisualStyleBackColor = true;
        this.BtnDoIt.Click += new System.EventHandler(this.BtnDoIt_Click);
        //
        // SubmitPrjPkgManage
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.groupBox1);
        this.Name = "SubmitPrjPkgManage";
        this.Size = new System.Drawing.Size(319, 148);
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox TxtLogID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button BtnDoIt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtMess;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox CmbxAction;
}
}
