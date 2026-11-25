import { PKW, LKW, Fahrrad } from "./Fahrzeug.ts";
import { Reifen } from "./Reifen.ts";
import { Garage } from "./Garage.ts";

const myBWMWith4Doors = new PKW("BMW", 4, "Benzin");
console.log(myBWMWith4Doors.Fahrzeugtyp);
console.log(myBWMWith4Doors.AnzahlTueren);

const myBWMWith2Doors = new PKW("BMW", 2, "Benzin");
console.log(myBWMWith2Doors.Fahrzeugtyp);
console.log(myBWMWith2Doors.AnzahlTueren);

const myMANWith2Doors = new LKW("MAN", 2, "Diesel");
console.log(myMANWith2Doors.Fahrzeugtyp);
console.log(myMANWith2Doors.AnzahlTueren);

const myFahrrad = new Fahrrad("Fahrrad", "Mountainbike", 21);
console.log(myFahrrad.Fahrzeugtyp);
console.log(myFahrrad.AnzahlGaenge);

const myGarage = new Garage();
myGarage.addFahrzeug(myBWMWith4Doors);
myGarage.addFahrzeug(myBWMWith2Doors);
myGarage.addFahrzeug(myMANWith2Doors);
myGarage.addFahrzeug(myFahrrad);
console.log(`Anzahl Autos: ${myGarage.anzahlAutos}`);

myGarage.addReifen(new Reifen("Michelin", 16, "Sommerreifen"));
myGarage.addReifen(new Reifen("Continental", 17, "Winterreifen"));

console.log(`Verkaufbare Dinge in der Garage: ${myGarage.verkaufbareDinge.length}`);