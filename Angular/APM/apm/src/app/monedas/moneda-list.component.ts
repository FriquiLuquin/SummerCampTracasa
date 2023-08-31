import { Component } from '@angular/core';

@Component({
  selector: 'pm-monedas',
  templateUrl: './moneda-list.component.html'
})
export class MonedaListComponent {
  pageTitle: string = 'Lista de Monedas';
  showImage: boolean = false;
  listFilter: string = "";

  monedas: any[] = [
    {
        "monedaId": 1,
        "nombre": "Euro",
        "codigo": "EUR",
        "simbolo": "€",
        "imageUrl": "http://s.exchangerate.net/small_flags/small_european_union_flag.gif"
    },
    {
        "monedaId": 2,
        "nombre": "Dolar",
        "codigo": "USD",
        "simbolo": "$",
        "imageUrl": "http://s.exchangerate.net/small_flags/small_united_states_flag.gif"
    },
    {
        "monedaId": 3,
        "nombre": "Libra",
        "codigo": "GBP",
        "simbolo": "£",
        "imageUrl": "http://s.exchangerate.net/small_flags/small_united_kingdom_flag.gif"
    }
  ];
  monedasFiltered: any[] = this.monedas;

  toggleImage(): void {
    this.showImage = !this.showImage;
  }

  filter() {
    let filterBy = this.listFilter.toLocaleLowerCase();
    this.monedasFiltered = this.monedas.filter((moneda: any) => moneda.nombre.toLocaleLowerCase().includes(filterBy));
  }
    
}
