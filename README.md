# Integrator Project 

![Integration.Core](https://github.com/onurkanbakirci/Integration/actions/workflows/integration-core.yml/badge.svg)
![Integration.Marketplaces.Trendyol](https://github.com/onurkanbakirci/Integration/actions/workflows/trendyol-integration.yml/badge.svg)

## Table of contents

- [Integrator Project](#integrator-project)
  - [Table of contents](#table-of-contents)
  - [Introduction](#introduction)
  - [Requirements](#requirements)
  - [Recommendations](#recommendations)
  - [Installation](#installation)
  - [Configuration](#configuration)
  - [Troubleshooting](#troubleshooting)
    - [FAQ](#faq)


## Introduction

The HISIM repo contains all source code about
hisim services such as app service, identity service,
management client service, app clients service etc.
All services are in a repo.


## Requirements

This module requires the following modules:

- [Views](https://www.drupal.org/project/views)
- [Panels](https://www.drupal.org/project/panels)


## Recommendations

[Postman](https://www.postman.com): When installed,
making requests to services will be easier.

## Installation


## Configuration

1. Enable the module at Administration > Extend.
1. When creating a new field on a content type or custom entity type, choose
   "Double Field" from the drop-down menu.
1. On the Field Settings form for the Double Field, define the two subfields
   as you would with any other field.
1. Optionally, on the "Edit" form for the Double Field, you may choose
   options for whether or not the subfields are "required".


## Troubleshooting

If the menu does not display, check the following:

- Are the "Access administration menu" and "Use the administration pages and
  help" permissions enabled for the appropriate roles?
- Does html.tpl.php of your theme output the `$page_bottom` variable?

### FAQ

Q: I enabled "Aggregate and compress CSS files", but admin_menu.css is still
there. Is this normal?

A: Yes, this is the intended behavior. the administration menu module only loads
its stylesheet as needed (i.e., on page requests by logged-on, administrative
users).
