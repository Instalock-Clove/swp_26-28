class Animal{
    private _name: string = "";
    private _colour: string = "";
    private _birthdate: Date;
 
    public get Name(): string {  return this._name; } // öffentliche Methode, um den Namen abzurufen
    public get Colour() { return this._colour}
    public get Birthdate(){return this._birthdate}
    public set Colour(value: string) {this._colour = value;}

    public makeSound() {console.log("Animal Sound")}
 
    public getAge() {
        let today = new Date();
        console.log(today.getFullYear() - this._birthdate.getFullYear()) 
    }

    constructor(name: string, colour: string, date: Date) { // Konstruktur => "konstruiert" einen Studenten
        this._name = name;
        this._colour = colour;
        this._birthdate = date;
    }
}
class Cow extends Animal {
   public makeSound() {console.log("Muuuhhh")}
}
class Cat extends Animal{
    public makeSound() {console.log("Miau")}
}

let myAnimal = new Animal("Animal","Brown",new Date("2018-12-01"));
myAnimal.makeSound()
let myCat = new Cat("Cookie", "Black",new Date("2014-7-14"));
myCat.makeSound();
myCat.getAge();
let myCow = new Cow("Cow0", "White",new Date("2015-02-01")); // erstellt eine Instanz der Student-Klasse
myCow.makeSound()
let myCow1 = new Cow("Cow1", "Black",new Date("2008-12-01"));
let myCow2 = myCow;
console.log(myCow.Name);
myCow.Colour ="Brown";
console.log(myCow2.Colour);