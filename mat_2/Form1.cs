using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

namespace mat_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateZnElements(BigInteger n, Label label1)
        {
            List<BigInteger> elements = new List<BigInteger>();

            for (BigInteger i = 1; i < n; i++)
            {
                if (GreatestCommonDivisor(i, n) == 1)
                {
                    elements.Add(i);
                }

                if (elements.Count >= 100)
                {
                    break;
                }
            }

            if (elements.Count == 0)
            {
                label1.Text = "Zbiór Z" + n + " nie posiada elementów.";
            }
            else
            {
                string elementsString = "Elementy zbioru Z" + n + ": ";
                foreach (BigInteger element in elements)
                {
                    elementsString += element.ToString() + " ";
                }

                label1.Text = elementsString;
            }
        }

        private void FindGenerator(BigInteger n, Label label1)
        {
            if (IsPrime(n))
            {
                List<BigInteger> factors = GetPrimeFactors(n - 1);

                for (BigInteger i = 2; i < n; i++)
                {
                    bool isGenerator = true;

                    foreach (BigInteger factor in factors)
                    {
                        if (BigInteger.ModPow(i, (n - 1) / factor, n) == 1)
                        {
                            isGenerator = false;
                            break;
                        }
                    }

                    if (isGenerator)
                    {
                        label1.Text += "Znaleziono generator: " + i.ToString();
                        return;
                    }
                }

                label1.Text = "Nie znaleziono generatora dla zbioru Z" + n;
            }
            else
            {
                label1.Text = "Zbiór Z" + n + " nie jest zbiorem liczb pierwszych.";
            }
        }

        private bool IsPrime(BigInteger n)
        {
            if (n <= 1)
                return false;

            for (BigInteger i = 2; i <= Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        private List<BigInteger> GetPrimeFactors(BigInteger n)
        {
            List<BigInteger> factors = new List<BigInteger>();

            for (BigInteger i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            return factors;
        }

        private BigInteger GreatestCommonDivisor(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private BigInteger Sqrt(BigInteger n)
        {
            if (n == 0)
                return 0;

            BigInteger x = (n + 1) / 2;
            BigInteger y = (x + n / x) / 2;

            while (y < x)
            {
                x = y;
                y = (x + n / x) / 2;
            }

            return x;
        }

        private void Go_button_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            BigInteger number;
            if (BigInteger.TryParse(cueTextBox2.Text, out number))
            {
                CalculateZnElements(number, label1);
                FindGenerator(number, label1);
            }
            else
            {
                label1.Text = "Nieprawidłowa liczba!";
            }
        }
    }
}
