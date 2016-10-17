import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/Observable';

import { IProduct } from './product';
import { HttpDataService } from "../Shared/Http/http-data.service";
import { productQueryUrl } from "./product.module";


@Component({
    moduleId: module.id,
    selector: 'pm-products',
    templateUrl: 'product-list.component.html',
    styleUrls: ["product-list.component.css"]
})

export class ProductListComponent implements OnInit{
    pageTitle: string = "Product List"
    imageWidth: number = 50;
    imageMargin: number = 2;
    showImage: boolean = false;
    listFilter: string = "";
    products: IProduct[];
    errorMessage: string;
    constructor(private http: HttpDataService<IProduct>) {
    }

    toggleImage(): void {
        this.showImage = !this.showImage;
    }

    ngOnInit(): void {
        console.log("In OnInit");
        this.http.getAll(productQueryUrl).subscribe((product: IProduct[]) => {
            this.products = product;
        });
    }

    onRatingClicked(message: string): void {
        this.pageTitle = "Product List: " + message;
    }
}