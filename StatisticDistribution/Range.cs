﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticDistribution
{
	/// <summary>
	/// Представляет диапазон
	/// </summary>
	public struct Range
	{
		public double Left { get; set; }		//Левая граница диапазона
		public double Right { get; set; }		//Правая граница диапазона
		public double Middle                    //Середина диапазона
		{
			get
			{
				return Left + (Right - Left) / 2.0;
			}
		}
		public double Length					//Длина интервала
		{
			get
			{
				return Right - Left;
			}
		}

		public Range(double left, double right)  :this()
		{
			Left = left;
			Right = right;
		}

		public override string ToString()
		{
			return "[" + Left.ToString() + "; " + Right.ToString() + ")";
		}
	}
}
