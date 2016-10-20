import { NgModule }      from "@angular/core";
import { FormsModule }   from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { HttpModule } from "@angular/http";

import { AppComponent }   from "./app.component";
import { ProductModule } from "./Products/product.module";
import { AppRoutingModule } from "./app-routing.module"
import { SharedModule } from "./Shared/shared.module";
import { LogModule } from "./Logs/log-table.module";

@NgModule({
    imports: [BrowserModule,
        HttpModule,
        FormsModule,
        ProductModule,
        LogModule,
        AppRoutingModule,
        SharedModule,
    ],
    declarations: [AppComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }