import { Component } from '@angular/core';
import { AuthService } from './_services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title = 'InterviewWebApp';
  saludo = 'Hola Mundo';
  nombre = '';

  constructor(
    public auth: AuthService
  ) { }

  cambiarNombre(){
    
  }
}
