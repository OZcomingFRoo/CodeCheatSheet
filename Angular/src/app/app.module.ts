import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app-component/app.component';
import { InOutDirectiveComponent } from './components/how-to/in-out-directive/in-out-directive.component';
import { PopupWindowComponent } from './components/utility/popup-window/popup-window.component';
import { NavComponent } from './components/nav/nav.component';
import { DefaultPageComponent } from './components/utility/default-page/default-page.component';
import { TheAuthPageComponent } from './components/others/the-auth-page/the-auth-page.component';
import { NotAuthPageComponent } from './components/others/not-auth-page/not-auth-page.component';
import { InputFileBtnPageComponent } from './components/others/input-file-btn-page/input-file-btn-page.component';
import { FormModelDrivenComponent } from './components/form-model-driven/form-model-driven.component';
import { FormTemplateDrivenComponent } from './components/form-template-driven/form-template-driven.component';
import { InputFileButtonComponent } from './components/utility/input-file-button/input-file-button.component';
import { UseElementRefComponent } from './components/how-to/use-element-ref/use-element-ref.component';
import { HowToComponent } from './components/how-to/how-to.component';
import { HostListenerComponent } from './components/how-to/host-listener/host-listener.component';
import { HowToHrComponent } from './components/how-to/how-to-hr/how-to-hr.component';
import { SimplePage1Component } from './components/others/simple-page1/simple-page1.component';
import { SimplePage2Component } from './components/others/simple-page2/simple-page2.component';
import { RoutingComponent } from './components/how-to/routing/routing.component';

@NgModule({
  declarations: [
    AppComponent,
    InOutDirectiveComponent,
    PopupWindowComponent,
    NavComponent,
    DefaultPageComponent,
    TheAuthPageComponent,
    NotAuthPageComponent,
    FormModelDrivenComponent,
    FormTemplateDrivenComponent,
    InputFileButtonComponent,
    InputFileBtnPageComponent,
    UseElementRefComponent,
    HowToComponent,
    HostListenerComponent,
    HowToHrComponent,
    SimplePage1Component,
    SimplePage2Component,
    RoutingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    CommonModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
