class Student {
    private _name: string = "John Doe";
 
    public getName(): string { // öffentliche Methode, um den Namen abzurufen
        return this._name;
    }
 
    constructor() { // Konstruktur => "konstruiert" einen Studenten
        this._name = "Namenlos";
    }
}
 
let myStudent = new Student(); // erstellt eine Instanz der Student-Klasse
console.log(myStudent.getName());
console.log(myStudent.getName());