﻿import { Component, OnInit, Inject } from '@angular/core';
import { Validators, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SectionsService } from '../../main/services/sections.service';
import { Section } from '../../../../entities/section';

@Component({
    selector: 'sectionsadmin',
    templateUrl: './sectionsadmin.component.html',
    providers: [SectionsService]
})
export class SectionsAdminComponent implements OnInit {
    isSuccessful: boolean;
    isRequesting: boolean;
    errors: string;  
    public sections: Section[];
    public section: Section;

    sectionForm = this.fb.group({
        id: [''],
        name: ['', Validators.required],
        modules: ['', Validators.required]
      });

    constructor(
        private sectionsService: SectionsService,
        private router: Router,
        private fb: FormBuilder,
        private route: ActivatedRoute
        ) {
    }

    ngOnInit() {
        this.sections = new Array();
        this.section = new Section();
        this.sectionsService.getSections('', '', '')
            .subscribe(sections => this.setSections(sections));
    }

    private setSections(sections: Section[])
    {
        this.sections = sections;
    }

    public save() {
        this.sectionsService.addOrUpdateSection(
            this.sectionForm.value['id'],
            this.sectionForm.value['name'],
            this.sectionForm.value['modules']
        )
        .finally(() => this.isRequesting = false)
        .subscribe(
        result  => {
            this.isSuccessful = true;
        },
        errors =>  this.errors = errors);
    }

    private saveSuccess(section: Section) {
        if (section.id != '0') {
            alert('Saved.');
            this.section = section;
            this.sections.push(this.section);
            this.section = new Section();
        }
        else {
            alert('Save failed.');
        }
    }

    private SaveResponse(data: any) {
        if (data != null) {
            if (data.value != null) {
                if (data.value == '0') {
                    alert('Saved.');
                } else {
                    alert('Save failed.');
                }
            } else {
                alert('Save failed.');
            }
        } else {
            alert('Save failed.');
        }
    }
}
