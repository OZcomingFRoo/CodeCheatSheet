import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormModelDrivenComponent } from './components/form-model-driven/form-model-driven.component';
import { FormTemplateDrivenComponent } from './components/form-template-driven/form-template-driven.component';
import { HowToComponent } from './components/how-to/how-to.component';
import { InOutDirectiveComponent } from './components/how-to/in-out-directive/in-out-directive.component';
import { RoutingComponent } from './components/how-to/routing/routing.component';
import { InputFileBtnPageComponent } from './components/others/input-file-btn-page/input-file-btn-page.component';
import { NotAuthPageComponent } from './components/others/not-auth-page/not-auth-page.component';
import { SimplePage1Component } from './components/others/simple-page1/simple-page1.component';
import { SimplePage2Component } from './components/others/simple-page2/simple-page2.component';
import { TheAuthPageComponent } from './components/others/the-auth-page/the-auth-page.component';
import { DefaultPageComponent } from './components/utility/default-page/default-page.component';
import { QueryAuthEqualTrueExampleGuard } from './Guards/query-auth-equal-true-example.guard';

const routes: Routes = [
  { component: HowToComponent, path: "HowTo" },
  { component: InputFileBtnPageComponent, path: "InputFileButton" },
  { component: FormModelDrivenComponent, path: "ReactiveForm" },
  { component: FormTemplateDrivenComponent, path: "TemplateDrivenForm" },
  { component: DefaultPageComponent, path: "Home" },
  { component: DefaultPageComponent, path: "DefaultPage" },
  { component: RoutingComponent, path: "HowTo/Route" },
  { component: SimplePage1Component, path: "Page1" },
  { component: SimplePage2Component, path: "Page2" },
  { component: DefaultPageComponent, path: "Default" },
  { component: TheAuthPageComponent, path: "AuthPage", canActivate: [QueryAuthEqualTrueExampleGuard] },
  { component: NotAuthPageComponent, path: "NotAuth" },
  { component: DefaultPageComponent, path: "**" },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
