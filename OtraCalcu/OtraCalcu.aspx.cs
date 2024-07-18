using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OtraCalcu
{

    public partial class OtraCalcu : System.Web.UI.Page
    {
        
       
        protected void Page_Load(object sender, EventArgs e)
        {
            // articulo.numero = 0; // no pueden estar fuera de un metodo, hecho con el profe
            InitializeCulture();
        }

        protected void Bnum0_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "0";
            }
            else
            {
                Lresultado.Text += "0";
            }
        }

        protected void Bpunto_Click(object sender, EventArgs e)
        {
            if (!Lresultado.Text.Contains("."))
            {
                Lresultado.Text += ".";
            }
        }

        protected void Bnum1_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "1";
            }
            else
            {
                Lresultado.Text += "1";
            }
        }

        protected void Bnum2_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "2";
            }
            else
            {
                Lresultado.Text += "2";
            }

        }

        protected void Bnum3_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "3";
            }
            else
            {
                Lresultado.Text += "3";
            }

        }

        protected void Bnum4_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "4";
            }
            else
            {
                Lresultado.Text += "4";
            }
        }

        protected void Bnum5_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "5";
            }
            else
            {
                Lresultado.Text += "5";
            }
        }

        protected void Bnum6_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "6";
            }
            else
            {
                Lresultado.Text += "6";
            }
        }

        protected void Bnum7_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "7";
            }
            else
            {
                Lresultado.Text += "7";
            }
        }

        protected void Bnum8_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "8";
            }
            else
            {
                Lresultado.Text += "8";
            }
        }

        protected void Bnum9_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text == "0")
            {
                Lresultado.Text = "9";
            }
            else
            {
                Lresultado.Text += "9";
            }
        }

        protected void Bmasmenos_Click(object sender, EventArgs e)
        {
            if (Lresultado.Text.Contains("-"))
            {
                Lresultado.Text = Lresultado.Text.Trim('-'); // elimina el - al inicio o al final

            }
            else
            {
                Lresultado.Text = "-" + Lresultado.Text;
            }
        }
        
        protected void Bresta_Click(object sender, EventArgs e)
        {
            decimal.TryParse(Lresultado.Text, out variables.num1);
            Lresultado.Text = "";
            variables.operador = "-";
        }

        protected void Bsuma_Click(object sender, EventArgs e)
        {
            decimal.TryParse(Lresultado.Text, out variables.num1);
            Lresultado.Text = "";// $" el numenro 1 es {variables.num1.ToString()}";
            variables.operador = "+";
        }

        protected void Bmultiplicacion_Click(object sender, EventArgs e)
        {
            decimal.TryParse(Lresultado.Text, out variables.num1);
            Lresultado.Text = "";
            variables.operador = "*";
        }

        protected void Bdivision_Click(object sender, EventArgs e)
        {            
            decimal.TryParse(Lresultado.Text, out variables.num1);
            Lresultado.Text = "";
            variables.operador = "/";
        }

        protected void Bfactorial_Click(object sender, EventArgs e)
        {
            int.TryParse(Lresultado.Text, out variables.num);
            Lresultado.Text =$"{variables.num.ToString()}!";
           variables.operador = "!";
        }

        protected void Bala2_Click(object sender, EventArgs e)
        {

            decimal.TryParse(Lresultado.Text, out variables.num1);
            Lresultado.Text = $"{variables.num1.ToString()}^2";
            variables.operador = "^";
        }

        protected void Blogaritmo_Click(object sender, EventArgs e)
        {
            double.TryParse(Lresultado.Text, out variables.numero);
            Lresultado.Text = $"log({variables.numero.ToString()})";
            variables.operador = "log";
        }


        protected void diezalax_Click(object sender, EventArgs e)
        {
            double.TryParse(Lresultado.Text, out variables.numero);
            Lresultado.Text = $"10^{variables.numero.ToString()}";
            variables.operador = "10^";
        }

        protected void Bxalay_Click(object sender, EventArgs e)
        {            
            double.TryParse(Lresultado.Text, out variables.numero);
            Lresultado.Text = "";
            variables.operador = "x^y";
        }

        protected void Braiz3_Click(object sender, EventArgs e)
        {
            double.TryParse(Lresultado.Text, out variables.numero);
            Lresultado.Text = $"{variables.numero.ToString()}^1/3";
            variables.operador = "^{1/3}";
        }
        protected void BLimpliar_Click(object sender, EventArgs e)
        {
            Lresultado.Text = "";
            variables.num1 = 0;
            variables.num2 = 0;
            variables.resultado = 0;
            variables.operador = "";
        }

        static void HacerPausa()
        {
            int milisegundosDePausa = 5000;
            Thread.Sleep(milisegundosDePausa);
        }
            


            protected void Bigual_Click(object sender, EventArgs e)
        {
            switch (variables.operador)
            {
                case "+":
                    decimal.TryParse(Lresultado.Text, out variables.num2);
                    variables.resultado = variables.num1 + variables.num2;
                    Lresultado.Text = variables.resultado.ToString();// $"El resultado es: {resultado.ToString()}";
                    break;

                case "-":
                    decimal.TryParse(Lresultado.Text, out variables.num2);
                    variables.resultado = variables.num1 - variables.num2;
                    Lresultado.Text = variables.resultado.ToString(); ;
                    break;

                case "*":
                    decimal.TryParse(Lresultado.Text, out variables.num2);
                    variables.resultado = variables.num1 * variables.num2;
                    Lresultado.Text = variables.resultado.ToString();
                    break;
                case "/":
                    decimal.TryParse(Lresultado.Text, out variables.num2);
                    variables.resultado = variables.num1 / variables.num2;
                    Lresultado.Text = variables.resultado.ToString();
                    break;

                case "!":
                    if (variables.num < 0)
                    {
                        Lresultado.Text = "Error de sintaxis";
                    }
                    if (variables.num == 0)
                    {
                        variables.resultado = 1;
                        Lresultado.Text = variables.resultado.ToString();
                    }
                    else
                    if (variables.num > 0)
                    {
                        variables.resultado = 1;
                        for (int i = 1; i <= variables.num; i++)
                        {
                            variables.resultado = variables.resultado * i;
                        }
                        Lresultado.Text = variables.resultado.ToString();
                    }
                    break;
                case "^":
                    variables.resultado = variables.num1 * variables.num1;
                    Lresultado.Text = variables.resultado.ToString();
                    break;
                case "log":
                    double resu;
                    resu = Math.Log10(variables.numero);
                    Lresultado.Text = resu.ToString();
                    break;
                case "10^":
                    double res;
                    res = Math.Pow(10, variables.numero);
                    // double.TryParse(variables.resultado, out rest);
                    Lresultado.Text = res.ToString();
                    break;

                case "x^y":
                    double.TryParse(Lresultado.Text, out variables.numero1);
                    double result;
                    result = Math.Pow(variables.numero, variables.numero1);
                    // double.TryParse(variables.resultado, out rest);
                    Lresultado.Text = result.ToString();
                    break;
                  case "^{1/3}":
                    double operacion;
                    operacion = Math.Pow(variables.numero,1.0/3.0);
                    Lresultado.Text = operacion.ToString();
                    break;
                case "":
                
                    break;

            }
            variables.num1 = 0;
            variables.num2 = 0;
            variables.resultado = 0;
            variables.operador = "";


        }

       
    }
}