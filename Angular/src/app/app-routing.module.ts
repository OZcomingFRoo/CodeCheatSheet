import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InOutDirectiveComponent } from './components/how-to/in-out-directive/in-out-directive.component';
import { DefaultPageComponent } from './components/utility/default-page/default-page.component';

const routes: Routes = [
  { component: InOutDirectiveComponent, path: "HowTo/InputOutput" },
  { component: DefaultPageComponent, path: "Home" },
  { component: DefaultPageComponent, path: "DefaultPage" },
  { component: DefaultPageComponent, path: "Default" },
  { component: DefaultPageComponent, path: "**" },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
