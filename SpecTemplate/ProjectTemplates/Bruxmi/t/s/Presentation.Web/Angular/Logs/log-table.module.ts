import { NgModule }  from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from "../app-routing.module"
import { SharedModule } from '../Shared/shared.module';
import { LogTableComponent } from './log-table.component';
import { LogUrlService } from "./log-url.service";
import { TooltipModule } from 'ng2-bootstrap/ng2-bootstrap';

@NgModule({
    imports: [
        FormsModule, CommonModule, SharedModule, AppRoutingModule, TooltipModule
    ],
    exports: [
        LogTableComponent
    ],
    declarations: [LogTableComponent],
    providers: [LogUrlService]
})
export class LogModule { }
