class Kuh {
    private _name: string = "";
    private _colour: string = "";
 
    public get Name(): string {  return this._name; } // öffentliche Methode, um den Namen abzurufen
    public get Colour() { return this._colour}
    public set Colour(value: string) {this._colour = value;}
 
    constructor(name: string, colour: string) { // Konstruktur => "konstruiert" einen Studenten
        this._name = name;
        this._colour = colour;
    }
}
 
let myKuh = new Kuh("Kuh0", "Weiß"); // erstellt eine Instanz der Student-Klasse
let myKuh1 = new Kuh("Kuh1", "schwarz");
let myKuh2 = myKuh;
console.log(myKuh.Name);
myKuh.Colour ="braun";
console.log(myKuh2.Colour);