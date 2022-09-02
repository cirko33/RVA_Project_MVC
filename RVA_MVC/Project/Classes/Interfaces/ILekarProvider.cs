///////////////////////////////////////////////////////////
//  IDataProviderT.cs
//  Implementation of the Interface ILekarProvider
//  Generated by Enterprise Architect
//  Created on:      29-Aug-2022 18:54:29
//  Original author: Luka
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace Classes {
	public interface ILekarProvider  {

		/// 
		/// <param name="id"></param>
		Lekar Dobavi(int id);

		/// 
		/// <param name="obj"></param>
		void Dodaj(Lekar obj);

		/// 
		/// <param name="id"></param>
		/// <param name="obj"></param>
		void Izmena(int id, Lekar obj);

		/// 
		/// <param name="id"></param>
		void Obrisi(int id);

		List<Lekar> Svi();
	}//end ILekarProvider

}//end namespace Classes