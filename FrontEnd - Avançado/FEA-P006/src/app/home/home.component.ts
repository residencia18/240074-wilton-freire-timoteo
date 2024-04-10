import { Component } from '@angular/core';
import { ApiConnectionService } from '../Services/api-connection.service';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule, CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
  dataForm!: FormGroup;
  data: any[] = [];
  constructor(private apiConnection: ApiConnectionService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.dataForm = this.formBuilder.group({});
    this.apiConnection.getBrasilData()
      .subscribe({
        next: (dataConnection) => {
          if (Array.isArray(dataConnection)) {
            const firstCountry = dataConnection[0];
            this.data = this.transformData(firstCountry);
            this.createForm(this.data);
          } else {
            console.error('Data received is not in expected format');
          }
        },
        error: (erro) => {
          console.error('Error fetching data from API:', erro);
        }
      })
  }

  transformData(data: any): any[] {
    const formData: any[] = [];
    for (const key in data) {
      if (data.hasOwnProperty(key)) {
        formData.push({
          type: 'text',
          nome: key,
          rotulo: key
        });
      }
    }
    return formData;
  }

  createForm(formData: any[]): void {
    const formGroupConfig: any = {};
    formData.forEach(field => {
      formGroupConfig[field.nome] = [''];
    });
    this.dataForm = this.formBuilder.group(formGroupConfig);
  }
}
