import { Component, Input,  OnInit, OnDestroy  } from '@angular/core';
import { Subscription } from 'rxjs';
import { PersonaService } from './person.service';
import { IPersona } from './Persona';

@Component({
  selector: 'app-persona',
  templateUrl: './persona.component.html',
  styleUrls: ['./persona.component.css']
  
})
export class PersonaComponent implements  OnInit{
  personas: IPersona[] = [];
  sub!: Subscription;
  errorMessage: string = '';

  constructor(private personaService: PersonaService) { }


  ngOnInit() {
    this.sub = this.personaService.getPersona().subscribe(
      (data: any) => {
        this.personas = data;
      },
      (error) => {
        this.errorMessage = 'Error al obtener datos: ' + error;
      }
    );
  }
  ngOnDestroy(): void {
    if (this.sub) {
      this.sub.unsubscribe();
    }
  }
}


