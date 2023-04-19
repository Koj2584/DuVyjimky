using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c1, c2;
            try
            {
                c1 = (int)numericUpDown1.Value;
                c2 = (int)numericUpDown2.Value;

                checked { label1.Text = "Sčítání: " + (c1 + c2) + "\nOdčítání: " + (c1 - c2) + "\nDělení: " + (c1 / c2) + "\nNásobení: " + (c1 * c2); }
            } catch(OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Přetečení!!");
            } catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Dělení nulou!!");
            } catch(ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Aritmetická chyba!!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n, soucet = 0;
            try
            {
                n = int.Parse(textBox2.Text);

                foreach(string s in textBox1.Lines)
                {
                    if(n>0)
                    {
                        try
                        {
                            checked { soucet += int.Parse(s); }
                        }
                        catch (FormatException ex)
                        { }
                        catch (OverflowException ex)
                        { }
                            n--;
                    }
                }
                label2.Text = "Soucet: "+soucet;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Vyskytla se chyba!!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Vyskytla se chyba!!");
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Vyskytla se chyba!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Vyskytla se chyba!!");
            }
        }

        Random r = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown3.Value;
            int[] pole = new int[n];

            for(int i = 0;i<n;i++)
            {
                pole[i] = r.Next(1, 21);
            }

            listBox1.Items.Clear();
            foreach(int i in pole)
            {
                listBox1.Items.Add(i);
            }

            try
            {
                label3.Text = "Umocnení: " + (Math.Pow(pole[0], pole[5]);
            } catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Je potřeba přidat počet čísel! "+ex.Message, "Chyba!!");
            } catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Chyba!!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba!!");
            }
        }
    }
}
