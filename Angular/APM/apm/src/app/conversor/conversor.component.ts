import { Component } from "@angular/core";
import { MonedaListComponent } from "../monedas/moneda-list.component";
import { IMoneda } from "../monedas/moneda";

@Component({
    selector: "pm-conversor",
    templateUrl: "./conversor.component.html"
})

export class ConversorComponent {
    pageTitle: string = 'Conversor de Monedas';
    monedaOrigenSelect: string = "";
    monedaDestinoSelect: string = "";
    importe: any;
    resultado: number = 1;
    conversionDone: boolean = false;
    monedas!: IMoneda[];

    constructor(private monedaListComponent: MonedaListComponent) {}

    hacerConversion(): void {
        // if (isNaN(parseFloat(this.importe))){
        //     alert("Introduce un valor valido")
        //     return
        // }
        // let monedaOrigen = this.monedas.find(m => m.Code === this.monedaOrigenSelect)
        // let monedaDestino = this.monedas.find(m => m.Code === this.monedaDestinoSelect)
        // let factor = monedaOrigen.FactorConversion / monedaDestino.FactorConversion
        // this.resultado = Number((Math.round(this.importe * factor * 100) / 100).toFixed(2).toLocaleString());
        // this.conversionDone = true
    }

    resetearConversion(): void {
        this.conversionDone = false
    }
}