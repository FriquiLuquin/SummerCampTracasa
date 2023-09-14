import { Component } from '@angular/core';
import { RegistroService } from './registro.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms'; // Importa las clases necesarias
import { Iregistro } from './registro';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent {
  myForm: FormGroup;
  sub!: Subscription;
  alta: Iregistro = {
  nombre: '',
  fechaNacimiento:'',
  telefono: ''
   
  };
 


  // Agrega una propiedad 'id' y genera un GUID en el constructor
  constructor(private altaService: RegistroService, public fb: FormBuilder) {
    this.myForm = this.fb.group({
      nombre: ['', [Validators.required,Validators.maxLength(50)]],
      fechaNacimiento: ['', [Validators.required,Validators.max(new Date(new Date().getFullYear() - 16).getTime())]],
      telefono:['', Validators.pattern(/^\d{3}-\d{3}-\d{4}$/)],
      
    });
  }

  rellenarAlta(myForm : FormGroup): void {
    const altaDTO: Iregistro = {
      nombre: myForm.value.nombre,   
      
      fechaNacimiento: myForm.value.fechaNacimiento,
      telefono: myForm.value.telefono
    };
    this.postAlta(altaDTO);
    console.log(altaDTO);
  }
  
 // Realiza el POST enviando el registro rellenado
 postAlta(altaDTO: Iregistro): void {
  this.altaService.postRealizarAlta(altaDTO).subscribe({
    next: (alta) => {
      this.alta = alta;
      console.log(alta);
    },
  });
}
}
