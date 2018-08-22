import gql from 'graphql-tag';

export const SectionsQuery = gql`
    query sectionsQuery(
        $id: Int!,
        $module: String!,
        $name: String!
    ) {
        sections(
            id: $id,
            module: $module,
            name: $name
        ) {
            id,
            createdBy,
            createdDate,
            lastUpdate,
            name
        }
    }
`;

export const SectionItemsQuery = gql`
    query sectionItemsQuery(
        $id: Int!,
        $section: String!,
        $path: String!,
        $alias: String!,
        $name: String!,
        $parentId: Int!,
        $isRoot: Boolean!
    ) {
        sectionitems(
            id: $id,
            section: $section,
            path: $path,
            alias: $alias,
            name: $name,
            parentId: $parentId,
            isRoot: $isRoot
        ) {
            id,
            createdBy,
            createdDate,
            lastUpdate,
            name,
            parentId,
            section,
            path,
            breadcrumb,
            alias,
            description
        }
    }
`;