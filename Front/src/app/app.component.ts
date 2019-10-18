import { Component, OnInit } from '@angular/core';
import { PessoaService } from 'src/services/pessoa.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [PessoaService]
})

export class AppComponent implements OnInit {
  
  title = 'TreinamentoWeb';
  pessoas: any[] = [];

  constructor(private pessoaService: PessoaService) {
    
  }

  ngOnInit() {
    this.pessoaService.buscarPessoas().subscribe(
      data => {
        this.pessoas = data;
      }
    );
  }

}
