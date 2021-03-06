﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULatina.Topicos.AdventureWorks.Model
{
    public partial class Product
    {
        public string SizeInInches
        {
            get
            {
                double laConversion;
                double lasPulgadas;
                string elResultado = string.Empty;
                if (SizeUnitMeasureCode == "CM") 
                    if (double.TryParse(Size, out laConversion))
                {
                        lasPulgadas = laConversion / 2.54;
                        elResultado = string.Format("{0} in.", lasPulgadas.ToString() );
                } else
                    {
                        elResultado = "Error"; 
                    } else
                {
                    elResultado = "Unidad Desconocida"; 
                }
                return elResultado;
            }
        }
    }
}
