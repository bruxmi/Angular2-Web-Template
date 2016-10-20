﻿import { NgModule }     from "@angular/core";
import { RouterModule } from "@angular/router";

import { WelcomeComponent }  from "./Home/welcome.component";
import { ProductListComponent }  from "./Products/product-list.component";
import { ProductDetailComponent }  from "./Products/product-detail.component";
import { LogTableComponent }  from "./Logs/log-table.component";

@NgModule({
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'welcome', pathMatch: 'full' },
            { path: 'welcome', component: WelcomeComponent },
            { path: 'products', component: ProductListComponent },
            { path: 'product/:id', component: ProductDetailComponent },
            { path: 'logs', component: LogTableComponent },
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutingModule { }