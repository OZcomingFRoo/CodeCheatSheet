import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InOutDirectiveComponent } from './components/how-to/in-out-directive/in-out-directive.component';
import { NotAuthPageComponent } from './components/others/not-auth-page/not-auth-page.component';
import { TheAuthPageComponent } from './components/others/the-auth-page/the-auth-page.component';
import { DefaultPageComponent } from './components/utility/default-page/default-page.component';
import { QueryAuthEqualTrueExampleGuard } from './Guards/query-auth-equal-true-example.guard';

const routes: Routes = [
  { component: InOutDirectiveComponent, path: "HowTo/InputOutput" },
  { component: DefaultPageComponent, path: "Home" },
  { component: DefaultPageComponent, path: "DefaultPage" },
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
