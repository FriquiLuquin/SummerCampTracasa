import { Component, OnDestroy, OnInit } from "@angular/core";
import { Subscription } from "rxjs";
import { IMoneda } from "../monedas/moneda";
import { MonedaService } from "../monedas/moneda.service";
import { ConversorService } from "./conversor.service";
import { IPeticionConversion } from "./peticion-conversion";

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
    monedas: IMoneda[] = [];
    errorMessage: string = '';
    sub!: Subscription;

    constructor(private monedaService: MonedaService, private conversorService: ConversorService) { }

    hacerConversion(): void {
        let peticionConversion = <IPeticionConversion>{
            importe: this.importe,
            monedaOrigenId: this.monedas.find(m => m.code === this.monedaOrigenSelect)?.id,
            monedaDestinoId: this.monedas.find(m => m.code === this.monedaDestinoSelect)?.id,
            idUsuario: "1d03a0ad-823b-4c28-a2f7-9ee42e2f2fde"
        };

        this.sub = this.conversorService.postConversion(peticionConversion).subscribe({
            next: result => {
              this.resultado = result.resultadoConversion;
              this.conversionDone = true;
            },
            error: err => this.errorMessage = err,
          });
        // if (isNaN(parseFloat(this.importe))){
        //     alert("Introduce un valor valido")
        //     return
        // }
        // let monedaOrigen = this.monedas.find(m => m.code === this.monedaOrigenSelect)
        // let monedaDestino = this.monedas.find(m => m.code === this.monedaDestinoSelect)
        // let factor = monedaDestino!.factorConversion / monedaOrigen!.factorConversion
        // this.resultado = Number((Math.round(this.importe * factor * 100) / 100).toFixed(2).toLocaleString());
        // this.conversionDone = true
    }

    resetearConversion(): void {
        this.conversionDone = false
    }

    ngOnInit(): void {
        this.sub = this.monedaService.getMonedas().subscribe({
          next: monedas => {
            this.monedas = monedas;
          },
          error: err => this.errorMessage = err
        });
      }
    
      ngOnDestroy(): void {
        this.sub.unsubscribe();
      }
}