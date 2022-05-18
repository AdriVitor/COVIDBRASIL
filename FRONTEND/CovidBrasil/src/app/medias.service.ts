import { Injectable } from '@angular/core';
import { IMedias } from './medias.interface';
import { HttpClient } from '@angular/common/http';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MediasService {

  constructor(private http: HttpClient){}

    listarMediaCasosUltimaSemana() : Observable<any> {
        return this.http.get<IMedias>("http://localhost:5116/2022-05-15T00:00:00").pipe(map(data => <IMedias>data))
    }
    listarMediaCasosPenultimaSemana() : Observable<any> {
      return this.http.get<IMedias>("http://localhost:5116/2022-05-07T00:00:00").pipe(map(data => <IMedias>data))
    }
    listarMediaCasosAntepenultimaSemana() : Observable<any> {
      return this.http.get<IMedias>("http://localhost:5116/2022-04-30T00:00:00").pipe(map(data => <IMedias>data))
  }
}
