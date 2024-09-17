using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FastAndEconomy
{
    public partial class purshaseForm : Form
    {
        private Dictionary<string, Dictionary<string, Dictionary<string, Image>>> colorImages;
        private string currentBrand;
        private string currentModel;

        public purshaseForm()
        {
            InitializeComponent();
            InitializeColorImages();
        }

        private void InitializeColorImages()
        {
            string basePath = Path.Combine(Application.StartupPath, "Image");
            colorImages = new Dictionary<string, Dictionary<string, Dictionary<string, Image>>>
            {
                {
                    "BMW", new Dictionary<string, Dictionary<string, Image>>
                    {
                        {
                            "x6m", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_x6m.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_x6m.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_x6m.png"))},
                            }
                        },
                        {
                            "m4 competition", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_m4_competition.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_m4_competition.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_m4_competition.png"))},
                            }
                        }
                    }
                },
                {
                    "Mercedes", new Dictionary<string, Dictionary<string, Image>>
                    {
                        {
                            "AMG GLS 63", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_amg_gls_63.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_amg_gls_63.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_amg_gls_63.png"))},
                            }
                        },
                        {
                            "AMG GT 63 S", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_amg_gt_63_s.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_amg_gt_63_s.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_amg_gt_63_s.png"))},
                            }
                        }
                    }
                },
                {
                    "Lexus", new Dictionary<string, Dictionary<string, Image>>
                    {
                        {
                            "IS 350 SPORT", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_is_350_sport.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_is_350_sport.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_is_350_sport.png"))},
                            }
                        },
                        {
                            "LX 600", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_lx_600.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_lx_600.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_lx_600.png"))},
                            }
                        }
                    }
                },
                {
                    "Aston Martin", new Dictionary<string, Dictionary<string, Image>>
                    {
                        {
                            "DB11", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_aston_martin.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_aston_martin.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_aston_martin.png"))},
                            }
                        },
                        {
                            "DBX 707", new Dictionary<string, Image>
                            {
                                { "white", Image.FromFile(Path.Combine(basePath, "white_dbx_707.png"))},
                                { "gray", Image.FromFile(Path.Combine(basePath, "gray_dbx_707.png"))},
                                { "red", Image.FromFile(Path.Combine(basePath, "red_dbx_707.png"))},
                            }
                        }
                    }
                }
            };
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            ChangeVehicleColor("white");
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            ChangeVehicleColor("red");
        }

        private void grayButton_Click(object sender, EventArgs e)
        {
            ChangeVehicleColor("gray");
        }

        private void ChangeVehicleColor(string color)
        {
            if (!string.IsNullOrEmpty(currentBrand) &&
                !string.IsNullOrEmpty(currentModel) &&
                colorImages.ContainsKey(currentBrand) &&
                colorImages[currentBrand].ContainsKey(currentModel) &&
                colorImages[currentBrand][currentModel].ContainsKey(color))
            {
                vehiculoPictureBox1.Image = colorImages[currentBrand][currentModel][color];
            }
            else
            {
                MessageBox.Show("No se pudo cambiar el color del vehículo. No están disponibles.");
            }
        }

        public void setVehicleName(string name)
        {
            marcaVehiculoLb.Text = name;

            // Determinar la marca y el modelo actual del vehículo según el nombre
            if (name.Contains("BMW x6m"))
            {
                currentBrand = "BMW";
                currentModel = "x6m";
            }
            else if (name.Contains("BMW m4 competition"))
            {
                currentBrand = "BMW";
                currentModel = "m4 competition";
            }
            else if (name.Contains("Mercedes AMG GLS 63"))
            {
                currentBrand = "Mercedes";
                currentModel = "AMG GLS 63";
            }
            else if (name.Contains("Mercedes AMG GT 63 S"))
            {
                currentBrand = "Mercedes";
                currentModel = "AMG GT 63 S";
            }
            else if (name.Contains("Lexus IS 350 SPORT"))
            {
                currentBrand = "Lexus";
                currentModel = "IS 350 SPORT";
            }
            else if (name.Contains("Lexus LX 600"))
            {
                currentBrand = "Lexus";
                currentModel = "LX 600";
            }
            else if (name.Contains("Aston Martin DB11"))
            {
                currentBrand = "Aston Martin";
                currentModel = "DB11";
            }
            else if (name.Contains("Aston Martin DBX 707"))
            {
                currentBrand = "Aston Martin";
                currentModel = "DBX 707";
            }
            else
            {
                currentBrand = null;
                currentModel = null;
            }
        }

        public void setVehiclePrice(string price)
        {
            precioVehiculoLb.Text = price;
        }

        public void setVehicleImage(Image image)
        {
            vehiculoPictureBox1.Image = image;
        }

        private void pagarBtn_Click(object sender, EventArgs e)
        {
            purshaseConfirmForm purshaseConfirmForm = new purshaseConfirmForm();
            purshaseConfirmForm.ShowDialog();
        }
    }
}
