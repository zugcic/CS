/*
Write a class that calculates the body mass index. 
The body mass index is calculated by the formula: kg / m2, ie the number of pounds per square in height. 
So for a person with a weight of 70 and a height of 1.80 m, the index should amount to 21.6.
In accordance with the table write a method in class that 
write in which category the person for which the data were entered.

BMI Classification
  <20 Underweight
  20 - 25 Ideal weight
25 - 30 Excessive body mass
  > 30 Obesity

If a person does not fall into the category of Ideal Weight,
call a function that counts how much a person should have a kilograms to have a body mass index 22.*/
using System;

namespace CS{
	class BodyMassIndex{
		double height;
		double weight;
		double mass_index;

		public BodyMassIndex(double weight,double height) {
			this.weight = weight;
			this.height = height;
		}
		public void Mass_index() {
			mass_index= weight / (height * height);
		}
		public void Classification() {
			if(mass_index < 20) {
				Console.WriteLine("Underweight");
			} else if(mass_index >= 20 && mass_index < 25) {
				Console.WriteLine("Ideal weight");
			} else if(mass_index > 25 && mass_index < 30) {
				Console.WriteLine("Excessive body mass");
			} else if(mass_index > 30) {
				Console.WriteLine("Obesity");
			}
		}
	}
	class ProgramBodyMassIndex{
		static void Main(){
			BodyMassIndex b=new BodyMassIndex(80,1.80);
			b.Mass_index();
			b.Classification();
		}
	}
}
