import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { IDados, IMedias } from './medias.interface';

@Injectable({
  providedIn: 'root'
})
export class DadosGeraisService {

  constructor(private http: HttpClient){}

    listarTodosOsCasos() : Observable<any> {
        return this.http.get<IDados>("http://localhost:5116/all").pipe(map(data => <IDados>data))
    }
}
