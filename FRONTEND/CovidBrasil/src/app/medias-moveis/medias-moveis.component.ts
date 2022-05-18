import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IMedias } from '../medias.interface';
import { MediasService } from '../medias.service';

@Component({
  selector: 'app-medias-moveis',
  templateUrl: './medias-moveis.component.html',
  styleUrls: ['./medias-moveis.component.css']
})
export class MediasMoveisComponent implements OnInit {

  httpOptions : any = {
    headers : new HttpHeaders({ 'Content-Type' : 'application/json' })
  }

  constructor(private mediasService : MediasService , private http : HttpClient) { }

  medias: IMedias[] = [];
  medias2: IMedias[] = [];
  medias3: IMedias[] = [];

  ngOnInit(): void {
    this.listarMediaCasosUltimaSemana();
    this.listarMediaCasosPenultimaSemana();
    this.listarMediaCasosAntepenultimaSemana()
    // this.httpRequest();
  }

  listarMediaCasosUltimaSemana(){
    this.mediasService.listarMediaCasosUltimaSemana().subscribe((data) => this.medias = data as [])}

    listarMediaCasosPenultimaSemana(){
    this.mediasService.listarMediaCasosPenultimaSemana().subscribe((data) => this.medias2 = data as [])}

    listarMediaCasosAntepenultimaSemana(){
    this.mediasService.listarMediaCasosAntepenultimaSemana().subscribe((data) => this.medias3 = data as [])}

}
