import { NgModule }      from "@angular/core";
import { FormsModule }   from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule } from "@angular/http";

import { AppComponent }   from "./app.component";
import { ProductModule } from "./Products/product.module";
import { AppRoutingModule } from "./app-routing.module"
import { WelcomeComponent } from "./Home/welcome.component";
import { SharedModule } from "./Shared/shared.module";

@NgModule({
    imports: [BrowserModule,
        HttpModule,
        FormsModule,
        ProductModule,
        AppRoutingModule,
        SharedModule
    ],
    declarations: [AppComponent, WelcomeComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }