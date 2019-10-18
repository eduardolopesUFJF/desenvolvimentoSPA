import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable()
export class PessoaService {

    urlApi = "http://localhost:65114/api/pessoa";

    constructor(private http: HttpClient) {
        
    }

    buscarPessoas() {
        return this.http.get<any[]>(this.urlApi);
    }

}