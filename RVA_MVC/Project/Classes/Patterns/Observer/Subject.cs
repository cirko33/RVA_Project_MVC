///////////////////////////////////////////////////////////
//  Subject.cs
//  Implementation of the Class Subject
//  Generated by Enterprise Architect
//  Created on:      29-Aug-2022 18:54:30
//  Original author: Luka
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Classes;
namespace Classes {
	public abstract class Subject {

		public List<Observer> m_Observer;

		public Subject(){
			m_Observer = new List<Observer>();
		}

		~Subject(){

		}

		/// 
		/// <param name="tekst"></param>
		public abstract void NotifyObservers();

		/// 
		/// <param name="observer"></param>
		public abstract void Register(Observer observer);

		/// 
		/// <param name="observer"></param>
		public abstract void Unregister(Observer observer);

	}//end Subject

}//end namespace Classes