﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_worldTests
{
	public class Meteo
	{
		public double Temperature { get; set; }
		public Temps Temps { get; set; }
	}

	public enum Temps
	{
		Soleil,
		Pluie
	}

}
