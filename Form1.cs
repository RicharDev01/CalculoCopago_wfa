using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoCopago
{
  public partial class Form1 : Form
  {

    // Definicion de variables
    float precioNormal;
    float descuentoAcordado;
    float precioArancel;
    float deducible;
    float porcentajeCoaseguro;
    float copago;
    float totalSeguro;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      precioNormal = 425.00F;
      descuentoAcordado = 0.10F;
      precioArancel = precioNormal - (precioNormal * descuentoAcordado);
      deducible = 0;
      porcentajeCoaseguro = 0.20F;
      copago = precioArancel * porcentajeCoaseguro;
      totalSeguro = precioArancel - copago;

      in_precioNormal.Text = $"{precioNormal}";
      in_descuentoAcordado.Text = $"{precioNormal*descuentoAcordado}";
      in_totalArancelado.Text = $"{precioArancel}";
      in_deducible.Text = $"{deducible}";
      in_porcentajeAprobado.Text = $"{porcentajeCoaseguro}";
      in_copago.Text = copago.ToString();
      in_creditoSeguro.Text = $"{totalSeguro}";
    }

    private void in_precioNormal_KeyUp(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Enter)
      {
        precioNormal = float.Parse(in_precioNormal.Text);
        descuentoAcordado = 0.10F;
        precioArancel = precioNormal - (precioNormal * descuentoAcordado);
        deducible = float.Parse(in_deducible.Text);
        porcentajeCoaseguro = float.Parse(in_porcentajeAprobado.Text);
        copago = precioArancel * porcentajeCoaseguro;
        totalSeguro = precioArancel - copago;

        in_precioNormal.Text = $"{precioNormal}";
        in_descuentoAcordado.Text = $"{precioNormal * descuentoAcordado}";
        in_totalArancelado.Text = $"{precioArancel}";
        in_deducible.Text = $"$ {deducible}";
        in_porcentajeAprobado.Text = $"{porcentajeCoaseguro}";
        in_copago.Text = $"{copago}";
        in_creditoSeguro.Text = $"{totalSeguro}";
      }
    }
  }
}
