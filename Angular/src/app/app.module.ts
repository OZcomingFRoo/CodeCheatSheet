import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app-component/app.component';
import { InOutDirectiveComponent } from './components/how-to/in-out-directive/in-out-directive.component';
import { PopupWindowComponent } from './components/utility/popup-window/popup-window.component';
import { NavComponent } from './components/nav/nav.component';
import { DefaultPageComponent } from './components/utility/default-page/default-page.component';
import { TheAuthPageComponent } from './components/others/the-auth-page/the-auth-page.component';
import { NotAuthPageComponent } from './components/others/not-auth-page/not-auth-page.component';

@NgModule({
  declarations: [
    AppComponent,
    InOutDirectiveComponent,
    PopupWindowComponent,
    NavComponent,
    DefaultPageComponent,
    TheAuthPageComponent,
    NotAuthPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
