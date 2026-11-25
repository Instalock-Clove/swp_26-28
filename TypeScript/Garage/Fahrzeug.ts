import { IVerkaufsartikel } from "./IVerkaufsartikel.ts";

export class Fahrzeug implements IVerkaufsartikel {
    private fahrzeugtyp: string;
    private name: string;
    verkaufsNamen: string;
    preis: number;

    get Fahrzeugtyp(): string {
        return this.fahrzeugtyp;
    }

    get Name(): string {
        return this.name;
    }

    constructor(fahrzeugtyp: string, name: string, preis: number) {
        this.fahrzeugtyp = fahrzeugtyp;
        this.name = name;
        this.verkaufsNamen = name;
        this.preis = preis;
    }
}

export class Fahrrad extends Fahrzeug {
    private anzahlGaenge: number;

    get AnzahlGaenge(): number {
        return this.anzahlGaenge;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlGaenge: number) {
        super(fahrzeugtyp, name, 500); // Beispielwert
        this.anzahlGaenge = anzahlGaenge;
    }
}

export class Auto extends Fahrzeug {
    private anzahlTueren: number;

    get AnzahlTueren(): number {
        return this.anzahlTueren;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlTueren: number) {
        super(fahrzeugtyp, name, 20000); // Beispielwert
        this.anzahlTueren = anzahlTueren;
    }
}

export class PKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("PKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

export class LKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("LKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}