import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppHomeComponent } from './app-home/app-home.component';
import { MediasMoveisComponent } from './medias-moveis/medias-moveis.component';

const routes: Routes = [
  {path:"", component: AppHomeComponent},
  {path:"mediasmoveis", component: MediasMoveisComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
