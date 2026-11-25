import { IVerkaufsartikel } from "./IVerkaufsartikel.ts";

export class Reifen implements IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
    marke: string;
    groesse: number;
    typ: string;

    constructor(marke: string, groesse: number, typ: string) {
        this.marke = marke;
        this.groesse = groesse;
        this.typ = typ;
        this.verkaufsNamen = marke;
        this.preis = 100; // Beispielwert
    }
}