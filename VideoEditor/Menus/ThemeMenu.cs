using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEditor
{
    public partial class SettingsTheme : Form
    {
        private Interface.GraphicTheme Theme_;

        private Interface Interface;

        public Color Default, Active, Loaded;

        public SettingsTheme()
        {
            InitializeComponent();
        }

        private void SettingsTheme_Load(object sender, EventArgs e)
        {
            Interface = new Interface();
            ThemeSelector.SelectedIndex = 0;
            ActiveList.SelectedIndex = 0;
        }

        #region dialog_result_buttons

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region main_functions

        private void ThemeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ThemeSelector.SelectedIndex)
            {
                case 0:
                    Theme_ = Interface.GraphicTheme.Dark;
                    Interface.SetBackground(panel1, Theme_); Interface.SetBackground(flowLayoutPanel2, Theme_);
                                                                                                         break;
                case 1:
                    Theme_ = Interface.GraphicTheme.Light;
                    Interface.SetBackground(panel1, Theme_); Interface.SetBackground(flowLayoutPanel2, Theme_);
                                                                                                         break;

                case 2:
                    Theme_ = Interface.GraphicTheme.Blue;
                    Interface.SetBackground(panel1, Theme_); Interface.SetBackground(flowLayoutPanel2, Theme_);
                                                                                                         break;
                default:
                    break;
            }
        }

        public Interface.GraphicTheme GetTheme()
        {
            return Theme_;
        }

        private void ActiveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(ActiveList.SelectedIndex)
            {
                case 0:
                             Default = Color.DarkRed;
                    panelDEFAULT.BackColor = Default;

                                Active = Color.Brown;
                      panelACTIVE.BackColor = Active;

                             Loaded = Color.DarkBlue;
                      panelLOADED.BackColor = Loaded;
                                               break;
                case 1:
                            Default = Color.DarkBlue;
                    panelDEFAULT.BackColor = Default;

                                 Active = Color.Blue;
                      panelACTIVE.BackColor = Active;

                               Loaded = Color.Yellow;
                      panelLOADED.BackColor = Loaded;
                                               break;
                case 2:
                              Default = Color.Yellow;
                    panelDEFAULT.BackColor = Default;
 
                          Active = Color.LightYellow;
                      panelACTIVE.BackColor = Active;

                                Loaded = Color.Brown;
                      panelLOADED.BackColor = Loaded;
                                               break;
                case 3:
                           Default = Color.DarkGreen;
                    panelDEFAULT.BackColor = Default;

                                Active = Color.Green;
                      panelACTIVE.BackColor = Active;

                               Loaded = Color.Yellow;
                      panelLOADED.BackColor = Loaded;
                                               break;

                case 4:
                          Default = Color.DarkOrange;
                    panelDEFAULT.BackColor = Default;

                               Active = Color.Orange;
                      panelACTIVE.BackColor = Active;

                               Loaded = Color.Yellow;
                      panelLOADED.BackColor = Loaded;
                                               break;

                case 5:
                          Default = Color.DarkViolet;
                    panelDEFAULT.BackColor = Default;

                               Active = Color.Purple;
                      panelACTIVE.BackColor = Active;

                                 Loaded = Color.Blue;
                      panelLOADED.BackColor = Loaded;
                                               break;

                case 6:
                    using (CUSTOM CS_menu = new CUSTOM()) {
                        CS_menu.Activate();
                        if(CS_menu.ShowDialog(this) == DialogResult.OK)
                        {
                            Default = Color.FromArgb(CS_menu.DR, CS_menu.DG, CS_menu.DB);
                                                        panelDEFAULT.BackColor = Default;

                             Active = Color.FromArgb(CS_menu.AR, CS_menu.AG, CS_menu.AB);
                                                          panelACTIVE.BackColor = Active;

                             Loaded = Color.FromArgb(CS_menu.LR, CS_menu.LG, CS_menu.LB);
                                                          panelLOADED.BackColor = Loaded;
                        }
                    }                                                              break;

                default:
                    break;
            }
        }
        
        #endregion
    }
}
