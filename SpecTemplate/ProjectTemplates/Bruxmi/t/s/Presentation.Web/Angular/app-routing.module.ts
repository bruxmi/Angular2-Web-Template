import { NgModule }     from "@angular/core";
import { RouterModule } from "@angular/router";

import { WelcomeComponent }  from "./Home/welcome.component";
import { ProductListComponent }  from "./Products/product-list.component";
import { ProductDetailComponent }  from "./Products/product-detail.component";

@NgModule({
    imports: [
        RouterModule.forRoot([
            { path: '', redirectTo: 'welcome', pathMatch: 'full' },
            { path: 'welcome', component: WelcomeComponent },
            { path: 'products', component: ProductListComponent },
            { path: 'product/:id', component: ProductDetailComponent }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class AppRoutingModule { }