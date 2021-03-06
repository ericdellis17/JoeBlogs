﻿using System;
using JoeBlogs;
using System.Reflection;
using System.Linq;

namespace JoeBlogs
{
    internal static class Map
    {
        internal static class From
        {
            internal static XmlRpcAuthor Author(Author input)
            {
                var content = new XmlRpcAuthor();
                content.display_name = input.DisplayName;
                content.user_email = input.EmailAddress;
                content.user_id = input.UserID;
                content.user_login = input.LoginName;
                return content;
            }
            internal static XmlRpcCategoryNew Category(CategoryNew input)
            {
                return new XmlRpcCategoryNew
                {
                    description = input.Description,
                    parentId = input.ParentCategoryID,
                    name = input.Name,
                    slug = input.Slug
                };
            }
            internal static XmlRpcCategory Category(Category input)
            {
                return new XmlRpcCategory
                {
                    categoryId = Convert.ToString(input.CategoryID),
                    categoryName = input.Name,
                    htmlUrl = input.HtmlUrl,
                    rssUrl = input.RSSUrl,
                    title = input.Name,
                    description = input.Description,
                    parentId = Convert.ToString(input.ParentCategoryID),
                };
            }
            internal static XmlRpcComment Comment(Comment input)
            {
                return new XmlRpcComment
                {
                    author = input.AuthorName,
                    author_email = input.AuthorEmail,
                    author_url = input.AuthorUrl,
                    comment_parent = input.CommentParentID,
                    content = input.Content,
                    post_id = input.PostID
                };
            }
            //internal static XmlRpcCommentResponse CommentResponse(CommentResponse input)
            //{
            //    return new XmlRpcCommentResponse
            //                    {
            //                        author = input.AuthorName,
            //                        author_email = input.AuthorEmail,
            //                        author_url = input.AuthorUrl,
            //                        author_ip=input.AuthorIP,
            //                        parent = Convert.ToString(input.CommentParentID),
            //                        content=input.Content,
            //                        comment_id=input.CommentID,
            //                        dateCreated=input.DateCreated,
            //                        link=input.Link,
            //                        post_id=input.PostID,
            //                        post_title=input.PostTitle,;
            //                    };
            //}
            internal static XmlRpcCommentCount CommentCount(CommentCount input)
            {
                return new XmlRpcCommentCount
                {
                    approved = input.Approved,
                    awaiting_moderation = input.AwaitingModeration,
                    spam = input.Spam,
                    total_comments = input.TotalComments
                };
            }
            internal static XmlRpcCommentFilter CommentFilter(CommentFilter input)
            {
                return new XmlRpcCommentFilter
                {
                    number = input.Number,
                    offset = input.Offset,
                    post_id = input.PostID,
                    status = input.Status
                };
            }
            internal static XmlRpcCustomField CustomField(CustomField input)
            {
                return new XmlRpcCustomField
                {
                    id = input.ID,
                    key = input.Key,
                    value = input.Value
                };
            }
            internal static XmlRpcData Data(Data input)
            {
                return new XmlRpcData
                {
                    base64 = input.Base64,
                    name = input.Name,
                    overwrite = input.Overwrite,
                    type = input.Type
                };
            }
            internal static XmlRpcFile File(File input)
            {
                return new XmlRpcFile
                {
                    file = input.file,
                    type = input.type,
                    url = input.url
                };
            }
            internal static XmlRpcMediaObject MediaObject(MediaObject input)
            {
                return new XmlRpcMediaObject
                {
                    bits = input.Bits,
                    name = input.Name,
                    type = input.Type
                };
            }
            internal static XmlRpcMediaObjectInfo MediaObjectInfo(MediaObjectInfo input)
            {
                return new XmlRpcMediaObjectInfo
                {
                    url = input.Url
                };
            }
            internal static XmlRpcOption Option(Option input)
            {
                return new XmlRpcOption
                {
                    option = input.Key,
                    value = input.Value
                };
            }
            internal static XmlRpcPage Page(Page input)
            {
                return new XmlRpcPage()
                {
                    dateCreated = input.DateCreated,
                    description = input.Body,
                    mt_allow_comments = input.AllowComments ? 1 : 0,
                    mt_allow_pings = input.AllowPings ? 1 : 0,
                    mt_excerpt = input.Excerpt,
                    mt_text_more = input.mt_text_more,
                    title = input.Title,
                    wp_author_id = input.AuthorID,
                    wp_page_order = input.PageOrder,
                    wp_page_parent_id = input.ParentPageID,
                    wp_password = input.Password,
                    wp_slug = input.Slug
                };
            }
            internal static XmlRpcPageMin PageMin(PageMin input)
            {
                return new XmlRpcPageMin()
                {
                    dateCreated = input.DateCreated,
                    page_parent_id = input.ParentPageID,
                    page_title = input.Title
                };
            }
            internal static XmlRpcPageTemplate PageTemplate(PageTemplate input)
            {
                return new XmlRpcPageTemplate()
                {
                    description = input.Description,
                    name = input.Name
                };
            }
            internal static XmlRpcPostStatusList PostStatusList(PostStatusList input)
            {
                return new XmlRpcPostStatusList()
                {
                    Status = input.Status
                };
            }
            internal static XmlRpcTagInfo Tag(Tag input)
            {
                return new XmlRpcTagInfo()
                {
                    count = input.Count,
                    html_url = input.HTMLUrl,
                    id = input.ID,
                    name = input.Name,
                    rss_url = input.RSSUrl,
                    slug = input.Slug
                };
            }
            internal static XmlRpcUserBlog UserBlog(UserBlog input)
            {
                return new XmlRpcUserBlog()
                {
                    blogId = input.BlogID,
                    blogName = input.BlogName,
                    isAdmin = input.IsAdmin,
                    url = input.URL,
                    xmlrpc = input.XMLRpc
                };
            }
            internal static XmlRpcUserInfo UserInfo(UserInfo input)
            {
                return new XmlRpcUserInfo()
                {
                    blogId = input.BlogID,

                };
            }
            internal static XmlRpcPost Post(Post input)
            {
                return new XmlRpcPost
                {
                    categories = input.Categories,
                    dateCreated = input.DateCreated,
                    description = input.Body,
                    mt_keywords = input.Tags,
                    postid = Convert.ToString(input.PostID),
                    title = input.Title
                };
            }
            internal static XmlRpcCategoryNew CategoryNew(CategoryNew input)
            {
                return new XmlRpcCategoryNew
                {
                    description = input.Description,
                    name = input.Name,
                    parentId = input.ParentCategoryID,
                    slug = input.Slug
                };
            }
        }

        internal static class To
        {
            internal static Author Author(XmlRpcAuthor input)
            {
                return new Author
                {
                    DisplayName = input.display_name,
                    EmailAddress = input.user_email,
                    LoginName = input.user_login,
                    UserID = input.user_id
                };
            }

            internal static Comment Comment(XmlRpcComment input)
            {
                var result = new Comment(input.post_id)
                {
                    AuthorEmail = input.author_email,
                    AuthorName = input.author,
                    AuthorUrl = input.author_url,
                    Content = input.content,
                };

                MapUtility.SetPrivateFieldValue<Comment>("CommentParentID", input.comment_parent, result);

                return result;
            }

            internal static CommentResponse CommentResponse(XmlRpcCommentResponse input)
            {
                var result = new CommentResponse
                {
                    AuthorEmail = input.author_email,
                    AuthorIP = input.author_ip,
                    AuthorName = input.author,
                    AuthorUrl = input.author_url,
                    CommentID = Convert.ToInt16(input.comment_id),
                    Content = input.content,
                    DateCreated = input.dateCreated,
                    Link = input.link,
                    PostID = Convert.ToInt16(input.post_id),
                    PostTitle = input.post_title,
                    UserID = Convert.ToInt16(input.user_id),
                    Status = EnumUtility.GetCommentStatus(input.status)
                };

                MapUtility.SetPrivateFieldValue<CommentResponse>("CommentID", input.comment_id, result);
                MapUtility.SetPrivateFieldValue<Comment>("CommentParentID", Convert.ToInt16(input.parent), result);

                return result;
            }

            internal static Post Post(XmlRpcPost input)
            {
                return new Post
                {
                    Body = input.description,
                    Categories = input.categories,
                    DateCreated = input.dateCreated,
                    Tags = input.mt_keywords,
                    Title = input.title
                };
            }

            internal static Page Page(XmlRpcPage input)
            {
                var result = new Page()
                {
                    AllowComments = (input.mt_allow_comments == 1 ? true : false),
                    AllowPings = (input.mt_allow_comments == 1 ? true : false),
                    AuthorID = input.wp_author_id,
                    Body = input.description,
                    DateCreated = input.dateCreated,
                    Excerpt = input.mt_excerpt,
                    mt_text_more = input.mt_text_more,
                    PageOrder = input.wp_page_order,
                    ParentPageID = input.wp_page_parent_id,
                    Password = input.wp_password,
                    Slug = input.wp_slug,
                    Title = input.title
                };

                MapUtility.SetPrivateFieldValue<Page>("_pageID", input.page_id, result);

                return result;
            }
            internal static Category Category(XmlRpcCategory input)
            {
                var result = new Category()
                {
                    ParentCategoryID = Convert.ToInt16(input.parentId),
                    Name = input.categoryName,
                    Description = input.description,
                    HtmlUrl = input.htmlUrl,
                    RSSUrl = input.rssUrl,
                };

                MapUtility.SetPrivateFieldValue<Category>("_categoryID", Convert.ToInt16(input.categoryId), result);

                return result;
            }
            internal static CategoryMin CategoryMin(XmlRpcCategoryMin input)
            {
                var result = new CategoryMin()
                {
                    Name = input.name,
                };

                MapUtility.SetPrivateFieldValue<CategoryMin>("_categoryID", Convert.ToInt16(input.category_id), result);

                return result;
            }

            internal static UserBlog UserBlog(XmlRpcUserBlog input)
            {
                var result = new UserBlog
                {
                    BlogName = input.blogName,
                    IsAdmin = input.isAdmin,
                    URL = input.url
                };

                MapUtility.SetPrivateFieldValue<UserBlog>("_userBlogID", input.blogId, result);

                return result;
            }

            internal static File File(XmlRpcFile input)
            {
                throw new NotImplementedException();
            }

            internal static MediaObjectInfo MediaObjectInfo(XmlRpcMediaObjectInfo result)
            {
                throw new NotImplementedException();
            }

            internal static CommentCount CommentCount(XmlRpcCommentCount input)
            {
                throw new NotImplementedException();
            }

            internal static Option Option(XmlRpcOption input)
            {
                throw new NotImplementedException();
            }

            internal static PageMin PageMin(XmlRpcPageMin input)
            {
                return new PageMin
                {
                    DateCreated = input.dateCreated,
                    PageID = Convert.ToInt16(input.page_id),
                    ParentPageID = input.page_parent_id,
                    Title = input.page_title
                };
            }

            internal static Tag TagInfo(XmlRpcTagInfo input)
            {
                return new Tag
                {
                    Count = input.count,
                    HTMLUrl = input.html_url,
                    ID = input.id,
                    Name = input.name,
                    RSSUrl = input.rss_url,
                    Slug = input.slug
                };
            }

            internal static PageTemplate PageTemplate(XmlRpcPageTemplate input)
            {
                throw new NotImplementedException();
            }

            internal static UserInfo UserInfo(XmlRpcUserInfo input)
            {
                throw new NotImplementedException();
            }

        }
    }
}